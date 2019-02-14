using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class IntegrateSource
    {
        #region Properties

        [DataMember(Name = "building")]
        public string Building { get; set; }

        [DataMember(Name = "databagId")]
        public string DatabagId { get; set; }

        [DataMember(Name = "fileId")]
        public long? FileId { get; set; }

        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "floor")]
        public string Floor { get; set; }

        [DataMember(Name = "floorSort")]
        public float? FloorSort { get; set; }

        /// <summary>
        ///     A name indicating the domain that the <see cref="IntegrateSource" /> belongs to
        /// </summary>
        /// <value>The name of the domain.</value>
        [DataMember(Name = "specialty")]
        public string Specialty { get; set; }

        [DataMember(Name = "specialtySort")]
        public float? SpecialtySort { get; set; }

        [DataMember(Name = "transform")]
        public double[] Transform { get; set; }

        #endregion
    }
}