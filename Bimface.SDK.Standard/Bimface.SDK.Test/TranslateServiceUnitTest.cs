#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public class TranslateServiceUnitTest : BimfaceUnitTest<ITranslateService>
    {
        #region Constructors

        public TranslateServiceUnitTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
            FileService = Client.GetService<IFileService>();
        }

        private IFileService FileService { get; }

        [Fact]
        public async void TestCreateTranslate()
        {
            var file = await FileService.Upload(new PullUploadParameter(Configuration.RemoteRevitFileName, Configuration.RemoteRevitFileUrl));
            Assert.NotNull(file);
            Assert.True(file.FileId.HasValue);
            var translate =
                await Service.CreateTranslate(
                    new CreateTranslateParameter(new FileTranslateRequest(new TranslateSource(file.FileId.Value, file.Name, false), 2)));
            Assert.NotNull(translate);
            Assert.True(translate.FileId == file.FileId);
        }

        #endregion
    }
}