using Bimface.SDK.Entities.Parameters.Data.DSL;

namespace Bimface.SDK.Requests.Data.DSL
{
    internal class ListRoomIdsDSLRequest : BimfaceDSLRequest
    {
        public ListRoomIdsDSLRequest(ListRoomIdsDSLParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/roomIds", apiVersion)
        {
        }
    }
}