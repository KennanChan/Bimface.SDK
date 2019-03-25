using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateAreasParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateAreasParameter(long integrateId, string floorId) : base(integrateId)
        {
            FloorId = floorId;
        }

        #endregion

        #region Properties

        public string FloorId { get; }

        #endregion
    }
}