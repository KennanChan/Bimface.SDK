using Bimface.SDK.Entities.Parameters.Data.DSL;

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListAreaIdsDSLRequest : BimfaceDSLRequest
    {
        #region Constructors

        public ListAreaIdsDSLRequest(ListAreaIdsDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/areaIds", apiVersion)
        {
        }

        #endregion
    }
}