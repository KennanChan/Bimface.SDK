#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Compare
{
    internal class CreateCompareRequest : BimfaceCompareRequest
    {
        #region Constructors

        public CreateCompareRequest(CreateCompareParameter parameter, string apiVersion = DefaultApiVersion)
            : base(HttpMethods.Post, "", apiVersion)
        {
            AddJsonBody(parameter.Request);
        }

        #endregion
    }
}