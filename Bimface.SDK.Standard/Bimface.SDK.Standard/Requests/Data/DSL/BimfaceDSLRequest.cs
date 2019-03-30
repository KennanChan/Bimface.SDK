#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Data.DSL;
using Bimface.SDK.Extensions;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Data.DSL
{
    [BimfaceAuth]
    public abstract class BimfaceDSLRequest : BimfaceDataApiRequest
    {
        #region Fields

        protected const string DefaultApiVersion = "v2";

        #endregion

        #region Constructors

        protected BimfaceDSLRequest(DSLParameter parameter, string method, string relativeApi, string apiVersion)
            : base(method, "/query".CombinePath(relativeApi),
                string.IsNullOrWhiteSpace(apiVersion) ? DefaultApiVersion : apiVersion)
        {
            AddJsonBody(parameter.Query);
        }

        protected BimfaceDSLRequest(DSLParameter parameter, string relativeApi, string apiVersion)
            : base("/query".CombinePath(relativeApi),
                string.IsNullOrWhiteSpace(apiVersion) ? DefaultApiVersion : apiVersion)
        {
            AddJsonBody(parameter.Query);
        }

        #endregion
    }
}