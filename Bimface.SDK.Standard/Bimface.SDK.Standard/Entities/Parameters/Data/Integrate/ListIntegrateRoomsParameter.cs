#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/rooms")]
    public class ListIntegrateRoomsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateRoomsParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string ElementId { get; set; }

        [HttpQueryComponent]
        public string FloorId { get; set; }

        [HttpQueryComponent]
        public Tolerance RoomToleranceXY { get; set; }

        [HttpQueryComponent]
        public Tolerance RoomToleranceZ { get; set; }

        #endregion
    }
}