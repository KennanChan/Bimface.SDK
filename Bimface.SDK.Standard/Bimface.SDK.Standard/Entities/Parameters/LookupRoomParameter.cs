namespace Bimface.SDK.Entities.Parameters
{
    public class LookupRoomParameter : FileParameter
    {
        public LookupRoomParameter(long? fileId, string roomId) : base(fileId)
        {
            RoomId = roomId;
        }

        public string RoomId { get; }
    }
}