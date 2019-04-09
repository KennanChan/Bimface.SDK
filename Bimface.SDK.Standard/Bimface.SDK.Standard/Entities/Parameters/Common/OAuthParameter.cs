using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Entities.Parameters.Common
{
    [BimfaceApiHttpRequest(HttpMethods.Post, "/oauth2/token")]
    internal class OAuthParameter : HttpParameter
    {
        public OAuthParameter(AppCredential credential)
        {
            Authorization = $"Basic {$"{credential.AppKey}:{credential.AppSecret}".Base64Encode()}";
        }

        [HttpHeaderComponent]
        public string Authorization { get; }
    }
}