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
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public class FileServiceUnitTest : BimfaceUnitTest<IFileService>
    {
        public FileServiceUnitTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
        }

        private async Task<List<FileEntity>> ListRecentFiles()
        {
            var today = DateTime.Now;
            var files = await Service.ListFiles(new ListFilesParameter {StartTime = today, EndTime = today + TimeSpan.FromDays(1)});
            return files;
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
            var policy = await Service.CreateUploadPolicy(new FetchUploadPolicyParameter(name));
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
                form.CopyTo(body, 4096, total => Output.WriteLine($"{total}/{httpRequest.ContentLength}"));
                body.Close();
                form.Close();
                formBuilder.Dispose();
            }

            var response = (HttpWebResponse) httpRequest.GetResponse();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
        }

        [Fact]
        public async void TestPullUploadFile()
        {
            var request  = WebRequest.CreateHttp(Configuration.RemoteRevitFileUrl);
            var response = (HttpWebResponse) request.GetResponse();
            Assert.True(response.StatusCode == HttpStatusCode.OK);
            var file = await Service.Upload(new PullUploadParameter(Configuration.RemoteRevitFileName, Configuration.RemoteRevitFileUrl));
            Assert.NotNull(file);

            var files   = await ListRecentFiles();
            var fileIds = files?.Select(f => f.FileId).ToArray();
            Assert.NotNull(fileIds);
            Output.WriteLine(string.Join(",", fileIds));
            Assert.Contains(file.FileId, fileIds);
        }

        [Fact]
        public async void TestPushUploadFile()
        {
            Assert.True(File.Exists(Configuration.LocalRevitFilePath));
            var file = await Service.Upload(new PushUploadParameter(Configuration.LocalRevitFilePath));
            Assert.NotNull(file);

            var files   = await ListRecentFiles();
            var fileIds = files?.Select(f => f.FileId).ToArray();
            Assert.NotNull(fileIds);
            Output.WriteLine(string.Join(",", fileIds));
            Assert.Contains(file.FileId, fileIds);
        }
    }
}