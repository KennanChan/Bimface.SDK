using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileElementPropertiesRequest : BimfaceFileDataApiRequest
    {
        public ListFileElementPropertiesRequest(ListFileElementPropertiesParameter parameter, string version = "v2")
            : base(parameter, $"/elements/{parameter.ElementId}", version)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}