#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/rooms/{roomId}")]
    public class LookupFileRoomParameter : FileParameter
    {
        #region Constructors

        public LookupFileRoomParameter(long fileId, string roomId) : base(fileId)
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