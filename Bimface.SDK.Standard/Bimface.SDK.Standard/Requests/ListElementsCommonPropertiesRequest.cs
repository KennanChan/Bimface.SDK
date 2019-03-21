using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    internal class ListElementsCommonPropertiesRequest : BimfaceDataApiRequest
    {
        public ListElementsCommonPropertiesRequest(ListElementsPropertiesParameter parameter, string version = "v2") : base(
            "/files/{fileId}/commonElementProperties", version)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}