using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Common
{
    [BimfaceAuth]
    internal class ViewTokenRequest : BimfaceApiRequest
    {
        #region Constructors

        public ViewTokenRequest() : base(HttpMethods.Get, "/view/token")
        {
        }

        #endregion
    }
}