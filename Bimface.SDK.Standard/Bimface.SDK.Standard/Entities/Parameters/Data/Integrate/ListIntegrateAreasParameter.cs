using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateAreasParameter : IntegrateParameter
    {
        public ListIntegrateAreasParameter(long integrateId, string floorId) : base(integrateId)
        {
            FloorId = floorId;
        }

        public string FloorId { get; }
    }
}