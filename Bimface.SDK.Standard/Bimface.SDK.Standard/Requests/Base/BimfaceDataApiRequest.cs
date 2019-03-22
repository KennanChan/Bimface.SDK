using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;

namespace Bimface.SDK.Requests.Base
{
    [BimfaceAuth]
    public abstract class BimfaceDataApiRequest : BimfaceApiRequest
    {
        protected const string DefaultApiVersion = "v2";

        protected BimfaceDataApiRequest(string method, string api, string apiVersion)
            : base(method, $"/data/${apiVersion}".CombinePath(api))
        {
        }

        protected BimfaceDataApiRequest(string api, string apiVersion)
            : base(HttpMethods.Get, $"/data/${apiVersion}".CombinePath(api))
        {
        }
    }
}