using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests.Base
{
    [BimfaceAuth]
    public abstract class BimfaceDataApiRequest : BimfaceApiRequest
    {
        protected BimfaceDataApiRequest(string method, string relativeApi, string apiVersion)
            : base(method, $"/data/${apiVersion}".CombinePath(relativeApi))
        {
        }

        protected BimfaceDataApiRequest(string relativeApi, string apiVersion)
            : base(HttpMethods.Get, $"/data/${apiVersion}".CombinePath(relativeApi))
        {
        }
    }
}