using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class LookupIntegrateAreaParameter : IntegrateParameter
    {
        public LookupIntegrateAreaParameter(long integrateId, string areaId) : base(integrateId)
        {
            AreaId = areaId;
        }

        public string AreaId { get; }
    }
}
