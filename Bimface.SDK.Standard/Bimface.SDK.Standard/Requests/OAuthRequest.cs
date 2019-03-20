using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests
{
    [HttpGet]
    public class OAuthRequest : BimfaceApiRequest
    {
        [Inject] protected AppCredential Credential { get; set; }

        public OAuthRequest() : base("/oauth2/token")
        {
            AddHeader("Authorization", $"Basic {$"{Credential.AppKey}:{Credential.AppSecret}".Base64Encode()}");
        }
    }
}