using Bimface.SDK.Entities.Parameters.Data.DSL;

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListAreaIdsDSLRequest : BimfaceDSLRequest
    {
        public ListAreaIdsDSLRequest(ListAreaIdsDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/areaIds", apiVersion)
        {
        }
    }
}
