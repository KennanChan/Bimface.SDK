#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/rooms/{roomId}")]
    public class LookupIntegrateRoomParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateRoomParameter(long integrateId, string roomId) : base(integrateId)
        {
            RoomId = roomId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string RoomId { get; }

        #endregion
    }
}