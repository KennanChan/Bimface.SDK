#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/areas/{areaId}")]
    public class LookupIntegrateAreaParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateAreaParameter(long integrateId, string areaId) : base(integrateId)
        {
            AreaId = areaId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string AreaId { get; }

        #endregion
    }
}