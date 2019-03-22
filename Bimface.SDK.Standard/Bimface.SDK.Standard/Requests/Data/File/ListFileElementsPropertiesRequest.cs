using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileElementsPropertiesRequest : BimfaceFileDataApiRequest
    {
        public ListFileElementsPropertiesRequest(ListFileElementsPropertiesParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/files/{parameter.FileId}/elements", apiVersion)
        {
            AddJsonBody(parameter.Request);
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}