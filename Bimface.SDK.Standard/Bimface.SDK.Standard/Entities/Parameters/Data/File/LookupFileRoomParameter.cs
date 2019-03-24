#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class LookupFileRoomParameter : FileParameter
    {
        public LookupFileRoomParameter(long fileId, string roomId) : base(fileId)
        {
            RoomId = roomId;
        }

        public string RoomId { get; }
    }
}