#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class LookupFileRoomMetaParameter : FileParameter
    {
        public LookupFileRoomMetaParameter(long fileId) : base(fileId)
        {
        }

        public string RoomId { get; set; }
    }
}