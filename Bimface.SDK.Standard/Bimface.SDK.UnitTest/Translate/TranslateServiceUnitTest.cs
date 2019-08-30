#region

using System;
using System.Linq;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test.Translate
{
    public class TranslateServiceUnitTest : BimfaceUnitTest
    {
        public TranslateServiceUnitTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
            FileService      = Client.GetService<IFileService>();
            TranslateService = Client.GetService<ITranslateService>();
        }

        private IFileService      FileService      { get; }
        private ITranslateService TranslateService { get; }

        [Fact]
        public async void TestTranslate()
        {
            var file = await FileService.Upload(new PullUploadParameter(Configuration.RemoteRevitFileName, Configuration.RemoteRevitFileUrl));
            Assert.NotNull(file);
            Assert.NotNull(file.FileId);
            var translate =
                await TranslateService.CreateTranslate(
                    new CreateTranslateParameter(new FileTranslateRequest(new TranslateSource(file.FileId.Value, file.Name, false))));
            Assert.NotNull(translate);
            Assert.True(translate.FileId == file.FileId);

            translate = await TranslateService.LookupTranslate(new LookupTranslateParameter(file.FileId.Value));
            Assert.NotNull(translate);
            Assert.True(translate.FileId == file.FileId);

            var request = new TranslateQueryRequest
                          {
                              StartDate =
                                  DateTime.Now - TimeSpan
                                     .FromDays(1),
                              EndDate =
                                  DateTime.Now + TimeSpan.FromDays(1)
                          };
            var translates = await TranslateService.ListTranslateDetails(new ListTranslateDetailsParameter(request));
            Assert.NotNull(translates);
            Assert.Contains(file.FileId, translates.List.Select(t => t.FileId));

            await FileService.DeleteFile(new DeleteFileParameter(file.FileId.Value));
            file = await FileService.LookupFileMeta(new LookupFileParameter(file.FileId.Value));
            Assert.Null(file);
        }
    }
}