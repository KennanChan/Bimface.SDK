using System.Net;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class FetchSupportFileTypesRequest : BimfaceFileRequest
    {
        public FetchSupportFileTypesRequest() : base(HttpMethods.Get, "/support")
        {
        }
    }
}
