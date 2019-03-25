using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class LookupIntegrateAreaParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateAreaParameter(long integrateId, string areaId) : base(integrateId)
        {
            AreaId = areaId;
        }

        #endregion

        #region Properties

        public string AreaId { get; }

        #endregion
    }
}