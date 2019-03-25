using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Data.Integrate
{
    [BimfaceAuth]
    internal abstract class BimfaceIntegrateDataApiRequest : BimfaceDataApiRequest
    {
        #region Fields

        protected const string DefaultApiVersion = "v2";

        #endregion

        #region Constructors

        protected BimfaceIntegrateDataApiRequest(IntegrateParameter parameter, string method, string relativeApi,
            string apiVersion)
            : base(method, $"/integrations/{parameter.IntegrateId}".CombinePath(relativeApi),
                string.IsNullOrWhiteSpace(apiVersion) ? DefaultApiVersion : apiVersion)
        {
        }

        protected BimfaceIntegrateDataApiRequest(IntegrateParameter parameter, string relativeApi, string apiVersion)
            : base($"/integrations/{parameter.IntegrateId}".CombinePath(relativeApi),
                string.IsNullOrWhiteSpace(apiVersion) ? DefaultApiVersion : apiVersion)
        {
        }

        #endregion
    }
}