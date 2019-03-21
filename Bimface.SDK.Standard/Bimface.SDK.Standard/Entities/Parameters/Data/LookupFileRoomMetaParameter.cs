using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data
{
    public class LookupFileRoomMetaParameter : FileParameter
    {
        public LookupFileRoomMetaParameter(long fileId) : base(fileId)
        {
        }

        public string RoomId { get; set; }
    }
}