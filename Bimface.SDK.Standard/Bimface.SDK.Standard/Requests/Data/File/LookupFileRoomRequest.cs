using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class LookupFileRoomRequest : BimfaceFileDataApiRequest
    {
        public LookupFileRoomRequest(LookupFileRoomParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/rooms/{parameter.RoomId}", apiVersion)
        {

        }
    }
}