using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileViewsRequest : BimfaceFileDataApiRequest
    {
        public ListFileViewsRequest(ListFileViewsParameter parameter, string version = "v2")
            : base(parameter, "/views", version)
        {
        }
    }
}
