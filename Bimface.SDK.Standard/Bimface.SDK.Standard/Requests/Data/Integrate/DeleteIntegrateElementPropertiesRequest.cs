using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class DeleteIntegrateElementPropertiesRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public DeleteIntegrateElementPropertiesRequest(DeleteIntegrateFileElementPropertiesParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, HttpMethods.Delete,
                $"/files/{parameter.FileIdHash}/elements/{parameter.ElementId}/properties", apiVersion)
        {
            AddJsonBody(parameter.Properties);
        }

        #endregion
    }
}