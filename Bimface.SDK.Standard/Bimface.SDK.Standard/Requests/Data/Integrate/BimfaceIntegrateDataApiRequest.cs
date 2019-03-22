using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.Integrate
{
    [BimfaceAuth]
    internal abstract class BimfaceIntegrateDataApiRequest : BimfaceDataApiRequest
    {
        protected new const string DefaultApiVersion = "v2";

        protected BimfaceIntegrateDataApiRequest(IntegrateParameter parameter, string method, string relativeApi, string apiVersion)
            : base(method, $"/integrates/{parameter.IntegrateId}".CombinePath(relativeApi), apiVersion)
        {
        }

        protected BimfaceIntegrateDataApiRequest(IntegrateParameter parameter, string relativeApi, string apiVersion)
            : base($"/integrates/{parameter.IntegrateId}".CombinePath(relativeApi), apiVersion)
        {
        }
    }
}