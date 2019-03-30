#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Requests.Base
{
    [BimfaceAuth]
    public abstract class BimfaceIntegrateApiRequest : BimfaceApiRequest
    {
        #region Constructors

        protected BimfaceIntegrateApiRequest(IntegrateParameter parameter, string method, string relativeApi)
            : base(method, $"/integrations/{parameter.IntegrateId}".CombinePath(relativeApi))
        {
        }

        #endregion
    }
}