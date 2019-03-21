using Bimface.SDK.Attributes;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Common
{
    public class OAuthRequest : BimfaceApiRequest
    {
        [Inject]
        protected AppCredential Credential { get; set; }

        public OAuthRequest() : base(HttpMethods.Get, "/oauth2/token")
        {
            AddHeader("Authorization", $"Basic {$"{Credential.AppKey}:{Credential.AppSecret}".Base64Encode()}");
        }
    }
}