using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ModifyFileElementPropertiesRequest : BimfaceFileDataApiRequest
    {
        public ModifyFileElementPropertiesRequest(ModifyFileElementPropertiesParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, HttpMethods.Put, $"/elements/{parameter.ElementId}/properties", apiVersion)
        {
            AddJsonBody(parameter.Properties);
        }
    }
}