#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Requests.Base
{
    [BimfaceAuth]
    public abstract class BimfaceCompareApiRequest : BimfaceApiRequest
    {
        #region Constructors

        protected BimfaceCompareApiRequest(CompareParameter parameter, string method, string relativeApi)
            : base(method, $"/comparisons/{parameter.CompareId}".CombinePath(relativeApi))
        {
        }

        #endregion
    }
}