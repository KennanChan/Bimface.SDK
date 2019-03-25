using Bimface.SDK.Entities.Parameters.Data.DSL;

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListPropertiesDSLRequest : BimfaceDSLRequest
    {
        #region Constructors

        public ListPropertiesDSLRequest(ListPropertiesDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/propertyValues", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }

        #endregion
    }
}