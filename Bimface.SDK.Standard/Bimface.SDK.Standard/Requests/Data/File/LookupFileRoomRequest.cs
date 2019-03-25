using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class LookupFileRoomRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public LookupFileRoomRequest(LookupFileRoomParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/rooms/{parameter.RoomId}", apiVersion)
        {
        }

        #endregion
    }
}