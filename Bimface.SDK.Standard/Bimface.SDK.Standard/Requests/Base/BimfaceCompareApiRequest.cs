using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests.Base
{
    [BimfaceAuth]
    public abstract class BimfaceCompareApiRequest : BimfaceApiRequest
    {
        protected BimfaceCompareApiRequest(CompareParameter parameter, string method, string relativeApi)
            : base(method, $"/comparisons/{parameter.CompareId}".CombinePath(relativeApi))
        {
        }
    }
}