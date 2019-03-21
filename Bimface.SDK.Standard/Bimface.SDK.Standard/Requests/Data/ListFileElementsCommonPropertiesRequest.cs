using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileElementsCommonPropertiesRequest : BimfaceFileDataApiRequest
    {
        public ListFileElementsCommonPropertiesRequest(ListFileElementsPropertiesParameter parameter, string version = "v2")
            : base(parameter, "/commonElementProperties", version)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}