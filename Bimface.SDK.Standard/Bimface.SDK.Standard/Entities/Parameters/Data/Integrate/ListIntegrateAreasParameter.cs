#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/areas")]
    public class ListIntegrateAreasParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateAreasParameter(long integrateId, string floorId) : base(integrateId)
        {
            FloorId = floorId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string FloorId { get; }

        #endregion
    }
}