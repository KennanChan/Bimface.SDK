using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    public abstract class BimfaceDataApiRequest : BimfaceApiRequest
    {
        protected BimfaceDataApiRequest(string method, string api, string version) : base(method, $"/data/${version}".CombinePath(api))
        {
        }

        protected BimfaceDataApiRequest(string api, string version) : base(HttpMethods.Get, $"/data/${version}".CombinePath(api))
        {
        }
    }
}