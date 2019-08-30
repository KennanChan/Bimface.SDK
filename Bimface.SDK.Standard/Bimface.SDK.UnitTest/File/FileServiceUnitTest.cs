#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test.File
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
            Assert.NotNull(fileId);
            return await FileService.LookupFileMeta(new LookupFileParameter(fileId.Value));
        }

        private async Task<FileUploadStatusEntity> GetFileUploadStatus(long? fileId)
        {
            Assert.NotNull(fileId);
            return await FileService.LookupFileUploadStatus(new LookupFileUploadStatusParameter(fileId.Value));
        }

        private async Task DeleteFile(long? fileId)
        {
            Assert.NotNull(fileId);
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
            Assert.NotNull(appendFileId);
            Assert.True(appendFile.Position.HasValue);
            Assert.True(appendFile.Length.HasValue);

            using (var fileStream = System.IO.File.OpenRead(localFile.FullName))
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
                    Assert.NotNull(appendFile);
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
            Assert.NotNull(file.FileId);
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
            Assert.NotNull(file.FileId);
            var info = await FileService.LookupFileMeta(new LookupFileParameter(file.FileId.Value));
            Output.WriteLine(JsonConvert.SerializeObject(info));
            Assert.NotNull(info);
            Assert.True(info.FileId == file.FileId);
        }

        [Fact]
        public async void TestListFiles()
        {
            var fileIds = (await ListRecentFiles())?.Select(f => f.FileId).ToArray();
            Output.WriteLine(string.Join("\n", fileIds ?? new long?[0]));
            Assert.NotNull(fileIds);
        }

        [Fact]
        public async void TestOssUploadFile()
        {
            Assert.True(System.IO.File.Exists(Configuration.LocalRevitFilePath));
            var file   = await FileService.OssUpload(Configuration.LocalRevitFilePath);
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
            Assert.True(System.IO.File.Exists(Configuration.LocalRevitFilePath));
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