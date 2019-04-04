#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/elementIds")]
    public class ListIntegrateElementIdsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateElementIdsParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public bool? AllNull { get; set; }

        [HttpQueryComponent]
        public string CategoryId { get; set; }

        [HttpQueryComponent]
        public string Family { get; set; }

        [HttpQueryComponent]
        public string FamilyType { get; set; }

        [HttpQueryComponent]
        public string Floor { get; set; }

        [HttpQueryComponent]
        public string PaginationContextId { get; set; }

        [HttpQueryComponent]
        public int? PaginationNo { get; set; }

        [HttpQueryComponent]
        public int? PaginationSize { get; set; }

        [HttpQueryComponent]
        public string RoomId { get; set; }

        [HttpQueryComponent]
        public Tolerance? RoomToleranceXY { get; set; }

        [HttpQueryComponent]
        public Tolerance? RoomToleranceZ { get; set; }

        [HttpQueryComponent]
        public string Specialty { get; set; }

        [HttpQueryComponent]
        public string SystemType { get; set; }

        #endregion
    }
}