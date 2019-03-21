using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class LookupFileRoomMetaRequest : BimfaceFileDataApiRequest
    {
        public LookupFileRoomMetaRequest(LookupFileRoomMetaParameter parameter, string version = "v2")
            : base(parameter, $"/rooms/{parameter.RoomId}", version)
        {

        }
    }
}