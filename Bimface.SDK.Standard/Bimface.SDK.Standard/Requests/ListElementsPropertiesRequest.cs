using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    internal class ListElementsPropertiesRequest : BimfaceDataApiRequest
    {
        public ListElementsPropertiesRequest(ListElementsPropertiesParameter parameter, string version = "v2") : base(
            $"/files/{parameter.FileId}/elements", version)
        {
            AddJsonBody(parameter.Request);
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}