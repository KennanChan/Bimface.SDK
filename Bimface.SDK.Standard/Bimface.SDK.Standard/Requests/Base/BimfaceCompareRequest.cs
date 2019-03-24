using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests.Base
{
    public abstract class BimfaceCompareRequest : BimfaceApiRequest
    {
        protected const string DefaultApiVersion = "v2";

        protected BimfaceCompareRequest(string method, string relativeApi, string apiVersion)
            : base(method, $"/{apiVersion}/compare".CombinePath(relativeApi))
        {
        }
    }
}
