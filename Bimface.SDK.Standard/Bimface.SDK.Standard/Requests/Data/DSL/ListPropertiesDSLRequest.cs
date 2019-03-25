using Bimface.SDK.Entities.Parameters.Data.DSL;

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListPropertiesDSLRequest : BimfaceDSLRequest
    {
        public ListPropertiesDSLRequest(ListPropertiesDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/propertyValues", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}
