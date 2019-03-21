using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileLinksRequest : BimfaceFileDataApiRequest
    {
        public ListFileLinksRequest(ListFileLinksParameter parameter, string version = "v2")
            : base(parameter, "/links", version)
        {
        }
    }
}