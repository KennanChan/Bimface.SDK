using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    internal class ListElementPropertiesRequest : BimfaceDataApiRequest
    {
        public ListElementPropertiesRequest(ListElementPropertiesParameter parameter, string version = "v2") : base(
            $"/files/{parameter.FileId}/elements/{parameter.ElementId}", version)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}