using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateRoomsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateRoomsParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        public string ElementId { get; set; }
        public string FloorId { get; set; }
        public Tolerance RoomToleranceXY { get; set; }
        public Tolerance RoomToleranceZ { get; set; }

        #endregion
    }
}