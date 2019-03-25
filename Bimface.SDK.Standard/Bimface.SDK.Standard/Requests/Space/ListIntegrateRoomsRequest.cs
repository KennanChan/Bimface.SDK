using Bimface.SDK.Entities.Parameters.Space;
using Bimface.SDK.Requests.Data.Integrate;

namespace Bimface.SDK.Requests.Space
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