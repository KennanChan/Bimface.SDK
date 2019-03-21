using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    internal class ListElementMaterialsRequest : BimfaceDataApiRequest
    {
        public ListElementMaterialsRequest(ListElementMaterialsParameter parameter, string version = "v2") : base(
            $"/files/{parameter.FileId}/elements/{parameter.ElementId}/materials", version)
        {
        }
    }
}
