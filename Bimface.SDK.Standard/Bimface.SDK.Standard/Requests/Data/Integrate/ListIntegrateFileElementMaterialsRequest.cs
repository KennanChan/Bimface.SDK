#region

using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateFileElementMaterialsRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateFileElementMaterialsRequest(ListIntegrateFileElementMaterialsParameter parameter,
                                                        string                                     apiVersion = DefaultApiVersion)
            : base(parameter, $"/files/{parameter.FileIdHash}/elements/{parameter.ElementId}/materials", apiVersion)
        {
        }

        #endregion
    }
}