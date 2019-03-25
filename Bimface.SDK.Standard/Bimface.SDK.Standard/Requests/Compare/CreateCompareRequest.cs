using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Compare
{
    internal class CreateCompareRequest : BimfaceCompareRequest
    {
        public CreateCompareRequest(CreateCompareParameter parameter, string apiVersion = DefaultApiVersion)
            : base(HttpMethods.Post, "", apiVersion)
        {
            AddJsonBody(parameter.Request);
        }
    }
}
