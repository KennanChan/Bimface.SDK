#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ModifyIntegrateFileElementPropertiesRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ModifyIntegrateFileElementPropertiesRequest(ModifyIntegrateFileElementPropertiesParameter parameter,
                                                           string                                        apiVersion = DefaultApiVersion)
            : base(parameter, HttpMethods.Put,
                $"/files/{parameter.FileIdHash}/elements/{parameter.ElementId}/properties", apiVersion)
        {
            AddJsonBody(parameter.Properties);
        }

        #endregion
    }
}