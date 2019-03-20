using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpGet]
    internal class ViewTokenRequest : BimfaceApiRequest
    {
        public ViewTokenRequest() : base("/view/token")
        {
        }
    }
}