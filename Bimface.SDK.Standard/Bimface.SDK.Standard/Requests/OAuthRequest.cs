using System.Net;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests
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