#region

using System.Linq;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Data.File;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Test.Extensions;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public class FileDataServiceUnitTest : BimfaceUnitTest
    {
        public FileDataServiceUnitTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
            FileDataService  = Client.GetService<IFileDataService>();
            FileService      = Client.GetService<IFileService>();
            TranslateService = Client.GetService<ITranslateService>();
        }

        private IFileDataService  FileDataService  { get; }
        private IFileService      FileService      { get; }
        private ITranslateService TranslateService { get; }

        [Fact]
        public async void TestListElementIds()
        {
            await FileService.TemporarilyUpload(Configuration.RemoteRevitFileUrl, Configuration.RemoteRevitFileName, async file =>
            {
                Assert.NotNull(file);
                Assert.True(file.FileId.HasValue);

                var translate = await TranslateService.EnsureTranslated(file);
                Assert.NotNull(translate);

                var elements = await FileDataService.ListElementIds(new ListFileElementIdsParameter(file.FileId.Value));
                Assert.NotNull(elements);
            });
        }

        [Fact]
        public async void TestListElementMaterials()
        {
            await FileService.TemporarilyUpload(Configuration.RemoteRevitFileUrl, Configuration.RemoteRevitFileName, async file =>
            {
                Assert.NotNull(file);
                Assert.True(file.FileId.HasValue);

                var translate = await TranslateService.EnsureTranslated(file);
                Assert.NotNull(translate);

                var elements = await FileDataService.ListElementIds(new ListFileElementIdsParameter(file.FileId.Value));

                var elementId = elements.FirstOrDefault();
                var materials = await FileDataService.ListElementMaterials(new ListFileElementMaterialsParameter(file.FileId.Value, elementId));

                Assert.NotNull(materials);
            });
        }

        [Fact]
        public async void TestListElementsProperties()
        {
            await FileService.TemporarilyUpload(Configuration.RemoteRevitFileUrl, Configuration.RemoteRevitFileName, async file =>
            {
                Assert.NotNull(file);
                Assert.True(file.FileId.HasValue);

                var translate = await TranslateService.EnsureTranslated(file);
                Assert.NotNull(translate);

                var elements = await FileDataService.ListElementIds(new ListFileElementIdsParameter(file.FileId.Value));

                var properties =
                    await FileDataService.ListElementsProperties(new ListFileElementsPropertiesParameter(file.FileId.Value,
                        new ElementPropertyFilterRequest(elements)));

                Assert.NotNull(properties);
            });
        }
    }
}