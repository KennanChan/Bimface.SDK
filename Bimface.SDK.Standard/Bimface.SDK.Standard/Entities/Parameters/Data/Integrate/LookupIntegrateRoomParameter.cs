using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class LookupIntegrateRoomParameter : IntegrateParameter
    {
        public LookupIntegrateRoomParameter(long integrateId, string roomId) : base(integrateId)
        {
            RoomId = roomId;
        }

        public string RoomId { get; }
    }
}