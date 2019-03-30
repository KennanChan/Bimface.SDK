#region

using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class LookupIntegrateRoomRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public LookupIntegrateRoomRequest(LookupIntegrateRoomParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/rooms/{parameter.RoomId}", apiVersion)
        {
        }

        #endregion
    }
}