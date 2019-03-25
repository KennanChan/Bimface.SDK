using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileElementMaterialsRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileElementMaterialsRequest(ListFileElementMaterialsParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, $"/elements/{parameter.ElementId}/materials", apiVersion)
        {
        }

        #endregion
    }
}