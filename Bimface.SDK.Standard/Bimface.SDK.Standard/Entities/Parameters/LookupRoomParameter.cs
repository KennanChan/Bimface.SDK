namespace Bimface.SDK.Entities.Parameters
{
    public class LookupRoomParameter : FileParameter
    {
        #region Constructors

        public LookupRoomParameter(long? fileId, string roomId) : base(fileId)
        {
            RoomId = roomId;
        }

        #endregion

        #region Properties

        public string RoomId { get; }

        #endregion
    }
}