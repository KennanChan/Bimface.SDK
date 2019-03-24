using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class LookupIntegrateRoomRequest : BimfaceIntegrateDataApiRequest
    {
        public LookupIntegrateRoomRequest(LookupIntegrateRoomParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/rooms/{parameter.RoomId}", apiVersion)
        {
        }
    }
}
