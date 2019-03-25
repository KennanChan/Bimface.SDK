using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class DeleteFileElementPropertiesRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public DeleteFileElementPropertiesRequest(DeleteFileElementPropertiesParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, HttpMethods.Delete, $"/elements/{parameter.ElementId}/properties", apiVersion)
        {
            AddJsonBody(parameter.Properties);
        }

        #endregion
    }
}