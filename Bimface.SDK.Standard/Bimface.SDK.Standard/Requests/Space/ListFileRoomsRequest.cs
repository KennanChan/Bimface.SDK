using Bimface.SDK.Entities.Parameters.Space;
using Bimface.SDK.Requests.Data.File;

namespace Bimface.SDK.Requests.Space
{
    internal class ListFileRoomsRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileRoomsRequest(ListFileRoomsParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/rooms", apiVersion)
        {
            AddQuery("elementId", parameter.ElementId);
            AddQuery("floorId", parameter.FloorId);
            AddQuery("roomToleranceXY", parameter.RoomToleranceXY);
            AddQuery("roomToleranceZ", parameter.RoomToleranceZ);
        }

        #endregion
    }
}