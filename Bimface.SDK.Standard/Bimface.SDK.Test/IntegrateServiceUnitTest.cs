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
        }

        private IFileService      FileService      { get; }
        private ITranslateService TranslateService { get; }
        private IIntegrateService IntegrateService { get; }

        [Fact]
        public async void TestIntegrate()
        {
            var files = await Task.WhenAll(
                            Configuration.LocalIntegrateRevitFilePaths.Select(path => FileService.Upload(new PushUploadParameter(path))));
            Assert.NotNull(files);
            Assert.True(files.Length > 1);
            Assert.True(files.All(file => file.FileId.HasValue));

            (FileEntity, FileTranslateEntity)[] translates;
            while ((translates = await Task.WhenAll(files.Select(file =>
                                     TranslateService.LookupTranslate(new LookupTranslateParameter(file.FileId.Value))
                                                     .ContinueWith(t => (file, t.Result)))))
               .Any(translate => translate.Item2?.Status != "success"))
            {
                translates = await Task.WhenAll(translates.Select(translate =>
                {
                    if (translate.Item2 == null)
                    {
                        return TranslateService.CreateTranslate(
                            new CreateTranslateParameter(
                                new FileTranslateRequest(new TranslateSource(translate.Item1.FileId.Value,
                                    translate.Item1.Name, false)))).ContinueWith(t => (translate.Item1, t.Result));
                    }

                    return Task.FromResult(translate);
                }));

                Assert.True(translates.All(translate => translate.Item2?.Status != "failed"));

                if (translates.Any(translate => translate.Item2 == null))
                {
                    continue;
                }

                if (translates.Any(translate => translate.Item2.Status != "success"))
                {
                    Thread.Sleep(3000);
                    continue;
                }

                break;
            }

            var integrate = await IntegrateService.CreateIntegrate(
                                new CreateIntegrateParameter(
                                    new FileIntegrateRequest
                                    {
                                        Sources = translates
                                                 .Select(translate =>
                                                      new IntegrateSource
                                                      {
                                                          FileId = translate
                                                                  .Item2.FileId
                                                      }).ToArray()
                                    }));
            Assert.NotNull(integrate);
        }
    }
}