using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateFileElementMaterialsRequest : BimfaceIntegrateDataApiRequest
    {
        public ListIntegrateFileElementMaterialsRequest(ListIntegrateFileElementMaterialsParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, $"/files/{parameter.FileIdHash}/elements/{parameter.ElementId}/materials", apiVersion)
        {
        }
    }
}
