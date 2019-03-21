using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileElementsPropertiesRequest : BimfaceFileDataApiRequest
    {
        public ListFileElementsPropertiesRequest(ListFileElementsPropertiesParameter parameter, string version = "v2")
            : base(parameter, $"/files/{parameter.FileId}/elements", version)
        {
            AddJsonBody(parameter.Request);
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}