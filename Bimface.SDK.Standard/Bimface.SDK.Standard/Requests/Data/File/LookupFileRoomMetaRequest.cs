using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class LookupFileRoomMetaRequest : BimfaceFileDataApiRequest
    {
        public LookupFileRoomMetaRequest(LookupFileRoomMetaParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, $"/rooms/{parameter.RoomId}", apiVersion)
        {

        }
    }
}