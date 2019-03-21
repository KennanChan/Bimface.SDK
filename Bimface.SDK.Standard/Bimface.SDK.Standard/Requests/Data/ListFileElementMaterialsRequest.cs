using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileElementMaterialsRequest : BimfaceFileDataApiRequest
    {
        public ListFileElementMaterialsRequest(ListFileElementMaterialsParameter parameter, string version = "v2")
            : base(parameter, $"/elements/{parameter.ElementId}/materials", version)
        {
        }
    }
}