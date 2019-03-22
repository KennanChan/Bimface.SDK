using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileViewsRequest : BimfaceFileDataApiRequest
    {
        public ListFileViewsRequest(ListFileViewsParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/views", apiVersion)
        {
        }
    }
}
