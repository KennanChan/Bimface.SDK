using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateRoomsRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateRoomsRequest(ListIntegrateRoomsParameter parameter, string apiVersion = DefaultApiVersion)
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