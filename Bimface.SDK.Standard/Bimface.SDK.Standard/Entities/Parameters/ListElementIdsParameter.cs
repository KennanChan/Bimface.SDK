using Bimface.SDK.Entities.Core;

namespace Bimface.SDK.Entities.Parameters
{
    public class ListElementIdsParameter : FileParameter
    {
        public ListElementIdsParameter(long? fileId) : base(fileId)
        {

        }

        public bool? AllNull { get; set; }

        public string CategoryId { get; set; }

        public string Family { get; set; }

        public string FamilyType { get; set; }

        public string Floor { get; set; }

        public string PaginationContextId { get; set; }

        public int? PaginationNo { get; set; }

        public int? PaginationSize { get; set; }

        public string RoomId { get; set; }

        public Tolerance? RoomToleranceXY { get; set; }

        public Tolerance? RoomToleranceZ { get; set; }

        public string Specialty { get; set; }

        public string SystemType { get; set; }
    }
}
