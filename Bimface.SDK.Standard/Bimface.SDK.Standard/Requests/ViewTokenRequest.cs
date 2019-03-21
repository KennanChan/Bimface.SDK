using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class ViewTokenRequest : BimfaceApiRequest
    {
        public ViewTokenRequest() : base(HttpMethods.Get, "/view/token")
        {
        }
    }
}