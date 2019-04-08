#region

using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Common
{
    public class OAuthRequest : BimfaceApiRequest
    {
        #region Constructors

        public OAuthRequest(AppCredential credential) : base(HttpMethods.Post, "/oauth2/token")
        {
            Credential = credential;
            AddHeader("Authorization", $"Basic {$"{Credential.AppKey}:{Credential.AppSecret}".Base64Encode()}");
        }

        #endregion

        #region Properties

        protected AppCredential Credential { get; }

        #endregion
    }
}