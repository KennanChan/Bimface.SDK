using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileElementsCommonPropertiesRequest : BimfaceFileDataApiRequest
    {
        public ListFileElementsCommonPropertiesRequest(ListFileElementsPropertiesParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/commonElementProperties", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}