using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class IntegrateFileEntity
    {
        [DataMember(Name = "databagId")]
        public string DatabagId { get; set; }

        [DataMember(Name = "drawingSheetCount")]
        public int? DrawingSheetCount { get; set; }

        [DataMember(Name = "fileId")]
        public long? FileId { get; set; }

        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "floor")]
        public string Floor { get; set; }

        [DataMember(Name = "floorSort")]
        public float FloorSort { get; set; }

        [DataMember(Name = "integrateId")]
        public long? IntegrateId { get; set; }

        [DataMember(Name = "linkedBy")]
        public object[] LinkedBy { get; set; }

        [DataMember(Name = "specialty")]
        public string Specialty { get; set; }

        [DataMember(Name = "specialtySort")]
        public float SpecialtySort { get; set; }
    }
}