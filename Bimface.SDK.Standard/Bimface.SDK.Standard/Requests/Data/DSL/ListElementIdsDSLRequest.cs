using Bimface.SDK.Entities.Parameters.Data.DSL;

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListElementIdsDSLRequest : BimfaceDSLRequest
    {
        public ListElementIdsDSLRequest(ListElementIdsDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/elementIds", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }
    }
}