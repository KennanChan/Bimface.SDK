#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public class FileServiceUnitTest : BimfaceUnitTest
    {
        public FileServiceUnitTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
            FileService = Client.GetService<IFileService>();
        }

        private IFileService FileService { get; }

        private int UploadBufferSize { get; } = 1024 * 1024;

        private async Task<List<FileEntity>> ListRecentFiles()
        {
            var today = DateTime.Now;
            var files = await FileService.ListFiles(new ListFilesParameter {EndTime = today + TimeSpan.FromDays(1)});
            return files;
        }

        private async Task<FileEntity> GetFirstFile()
        {
            var files = await ListRecentFiles();
            var file  = files.FirstOrDefault();
            Assert.NotNull(file);
            return file;
        }

        private async Task<FileEntity> GetFile(long? fileId)
        {
            Assert.True(fileId.HasValue);
            return await FileService.LookupFileMeta(new LookupFileParameter(fileId.Value));
        }

        private async Task<FileUploadStatusEntity> GetFileUploadStatus(long? fileId)
        {
            Assert.True(fileId.HasValue);
            return await FileService.LookupFileUploadStatus(new LookupFileUploadStatusParameter(fileId.Value));
        }

        private async Task DeleteFile(long? fileId)
        {
            Assert.True(fileId.HasValue);
            await FileService.DeleteFile(new DeleteFileParameter(fileId.Value));
        }

        private async Task AssertDeleteFile(long? fileId)
        {
            await DeleteFile(fileId);
            var file = await GetFile(fileId);
            Assert.Null(file);
        }

        [Fact]
        public async void TestAppendFile()
        {
            var localFile  = new FileInfo(Configuration.LocalRevitFilePath);
            var name       = Path.GetFileName(localFile.FullName);
            var appendFile = await FileService.CreateAppendFile(new CreateAppendFileParameter(name, localFile.Length));
            Assert.NotNull(appendFile);

            //persist this value to continue uploading next time
            var appendFileId = appendFile.AppendFileId;
            Assert.True(appendFileId.HasValue);
            Assert.True(appendFile.Position.HasValue);
            Assert.True(appendFile.Length.HasValue);

            using (var fileStream = File.OpenRead(localFile.FullName))
            {
                while (appendFile.Position < appendFile.Length)
                {
                    var buffer = new byte[UploadBufferSize];
                    Assert.True(appendFile.Length == localFile.Length);
                    fileStream.Seek(appendFile.Position.Value, SeekOrigin.Begin);
                    var count  = fileStream.Read(buffer, 0, UploadBufferSize);
                    var stream = new MemoryStream(buffer, 0, count);
                    appendFile = await FileService.ResumeAppendFile(new ResumeAppendFileParameter(appendFileId.Value, appendFile.Position.Value,
                                     stream));
                    Assert.True(appendFile.AppendFileId.HasValue);
                    Assert.True(appendFileId == appendFile.AppendFileId);
                    Assert.True(appendFile.Position.HasValue);
                    Assert.True(appendFile.Length.HasValue);
                }
            }

            await AssertDeleteFile(appendFile.File.FileId);
        }

        [Fact]
        public async void TestDownloadFile()
        {
            var file = await GetFirstFile();
            Assert.True(file.FileId.HasValue);
            var url = await FileService.FetchFileTemporaryDownloadUrl(new FileDownloadAddressParameter(file.FileId.Value));
            Output.WriteLine(url);
            Assert.NotNull(url);
            var request  = WebRequest.CreateHttp(url);
            var response = (HttpWebResponse) request.GetResponse();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

        [Fact]
        public async void TestGetFileInfo()
        {
            var file = await GetFirstFile();
            Assert.True(file.FileId.HasValue);
            var info = await FileService.LookupFileMeta(new LookupFileParameter(file.FileId.Value));
            Output.WriteLine(JsonConvert.SerializeObject(info));
            Assert.NotNull(info);
            Assert.True(info.FileId == file.FileId);
        }

        [Fact]
        public async void TestListFiles()
        {
            var fileIds = (await ListRecentFiles())?.Select(f => f.FileId).ToArray();
            Output.WriteLine(string.Join(",", fileIds));
            Assert.NotNull(fileIds);
        }

        [Fact]
        public async void TestOssUploadFile()
        {
            Assert.True(File.Exists(Configuration.LocalRevitFilePath));
            var name   = Path.GetFileName(Configuration.LocalRevitFilePath);
            var policy = await FileService.CreateUploadPolicy(new FetchUploadPolicyParameter(name));
            Assert.NotNull(policy);
            var httpRequest = WebRequest.Create(new Uri(policy.Host));
            httpRequest.Method = WebRequestMethods.Http.Post;

            var formBuilder = new MultiPartFormDataBuilder()
                             .AddForm("name", name)
                             .AddForm("key", policy.ObjectKey)
                             .AddForm("policy", policy.Policy)
                             .AddForm("OSSAccessKeyId", policy.AccessId)
                             .AddForm("success_action_status", "200")
                             .AddForm("callback", policy.CallbackBody)
                             .AddForm("Expires", policy.Expire.ToString())
                             .AddForm("Signature", policy.Signature)
                             .AddFile(name, File.OpenRead(Configuration.LocalRevitFilePath));
            httpRequest.ContentType = $"multipart/form-data; boundary={formBuilder.Boundary}";

            using (var form = formBuilder.Build())
            {
                //Notify the socket about the length of the body in order to produce progress
                httpRequest.ContentLength = form.Length;
                var body = httpRequest.GetRequestStream();
                form.Seek(0, SeekOrigin.Begin);
                form.CopyTo(body, UploadBufferSize, total => Output.WriteLine($"{total}/{httpRequest.ContentLength}"));
                body.Close();
                form.Close();
                formBuilder.Dispose();
            }

            var response = (HttpWebResponse) httpRequest.GetResponse();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
            var file = Client.GetService<IResponseResolver>().Resolve<FileEntity>(response.GetResponseStream());
            Assert.NotNull(file);
            var status = await GetFileUploadStatus(file.FileId);
            Assert.True(status.FileId == file.FileId);
        }

        [Fact]
        public async void TestPullUploadFile()
        {
            var request  = WebRequest.CreateHttp(Configuration.RemoteRevitFileUrl);
            var response = (HttpWebResponse) request.GetResponse();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
            var file = await FileService.Upload(new PullUploadParameter(Configuration.RemoteRevitFileName, Configuration.RemoteRevitFileUrl));
            Assert.NotNull(file);

            var fileId = file.FileId;
            file = await GetFile(file.FileId);
            Assert.NotNull(file);
            Assert.True(fileId == file.FileId);

            await AssertDeleteFile(file.FileId);
        }

        [Fact]
        public async void TestPushUploadFile()
        {
            Assert.True(File.Exists(Configuration.LocalRevitFilePath));
            var file = await FileService.Upload(new PushUploadParameter(Configuration.LocalRevitFilePath));
            Assert.NotNull(file);

            var fileId = file.FileId;
            file = await GetFile(file.FileId);
            Assert.NotNull(file);
            Assert.True(fileId == file.FileId);

            await AssertDeleteFile(file.FileId);
        }

        [Fact]
        public async void TestSupportFileType()
        {
            var types = await FileService.ListSupportFileTypes(new ListSupportFileTypesParameter());
            Assert.NotNull(types);
            Assert.True(types.Length       > 0);
            Assert.True(types.Types.Length > 0);
        }
    }
}