#region

using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Test.Extensions;
using Xunit;
using Xunit.Abstractions;

#endregion

namespace Bimface.SDK.Test
{
    public class IntegrateServiceUnitTest : BimfaceUnitTest
    {
        public IntegrateServiceUnitTest(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
        {
            FileService      = Client.GetService<IFileService>();
            IntegrateService = Client.GetService<IIntegrateService>();
            TranslateService = Client.GetService<ITranslateService>();
            JsonSerializer   = Client.GetService<IJsonSerializer>();
        }

        private IFileService      FileService      { get; }
        private ITranslateService TranslateService { get; }
        private IIntegrateService IntegrateService { get; }
        private IJsonSerializer   JsonSerializer   { get; }

        [Fact]
        public async void TestIntegrate()
        {
            await FileService.TemporarilyUpload(Configuration.LocalIntegrateRevitFilePaths, async files =>
            {
                Assert.NotNull(files);
                Assert.True(files.Length > 1);
                Assert.True(files.All(file => file.FileId.HasValue));

                var translates = await Task.WhenAll(files.Select(file => TranslateService.EnsureTranslated(file)));

                var request = new FileIntegrateRequest
                              {
                                  Sources = translates
                                           .Select(translate =>
                                                new IntegrateSource
                                                {
                                                    FileId = translate.FileId
                                                }).ToArray()
                              };
                Output.WriteLine(JsonSerializer.Serialize(request));
                var integrate = await IntegrateService.CreateIntegrate(new CreateIntegrateParameter(request));
                Assert.NotNull(integrate);
            });
        }
    }
}