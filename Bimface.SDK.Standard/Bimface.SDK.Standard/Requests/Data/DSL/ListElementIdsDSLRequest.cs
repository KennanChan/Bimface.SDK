#region

using Bimface.SDK.Entities.Parameters.Data.DSL;

#endregion

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListElementIdsDSLRequest : BimfaceDSLRequest
    {
        #region Constructors

        public ListElementIdsDSLRequest(ListElementIdsDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/elementIds", apiVersion)
        {
            AddNullableQuery("includeOverrides", parameter.IncludeOverrides);
        }

        #endregion
    }
}