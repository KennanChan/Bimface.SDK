using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpGet]
    internal class FetchSupportFileTypesRequest : BimfaceFileRequest
    {
        public FetchSupportFileTypesRequest() : base("/support")
        {
        }
    }
}
