using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Share
{
    internal class ListSharesRequest : BimfaceApiRequest
    {
        public ListSharesRequest(ListSharesParameter parameter) : base(HttpMethods.Get, "/shares")
        {
        }
    }
}