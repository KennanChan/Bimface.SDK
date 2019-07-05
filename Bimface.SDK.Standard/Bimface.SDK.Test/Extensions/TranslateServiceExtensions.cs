#region

using System.Threading;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Interfaces.Core;
using Xunit;

#endregion

namespace Bimface.SDK.Test.Extensions
{
    internal static class TranslateServiceExtensions
    {
        #region Others

        internal static async Task<FileTranslateEntity> EnsureTranslated(this ITranslateService translateService, FileEntity file)
        {
            Assert.NotNull(file);
            Assert.True(file.FileId.HasValue);

            FileTranslateEntity translate;
            while ((translate = await translateService.LookupTranslate(new LookupTranslateParameter(file.FileId.Value))) == null ||
                   translate.Status                                                                                      != "success")
            {
                if (translate == null)
                {
                    translate = await translateService.CreateTranslate(
                                    new CreateTranslateParameter(new FileTranslateRequest(new TranslateSource(file.FileId, file.Name, false))));
                }

                Assert.True(translate?.Status != "failed");

                if (null == translate)
                {
                    continue;
                }

                if (translate.Status != "success")
                {
                    Thread.Sleep(3000);
                    continue;
                }

                break;
            }

            return translate;
        }

        #endregion
    }
}