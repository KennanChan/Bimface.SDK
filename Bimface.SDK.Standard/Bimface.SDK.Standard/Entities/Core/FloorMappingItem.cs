using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class FloorMappingItem
    {
        #region Properties

        [DataMember(Name = "fileFloorId")]
        public string FileFloorId { get; set; }

        [DataMember(Name = "projectFloorId")]
        public string ProjectFloorId { get; set; }

        [DataMember(Name = "projectFloorName")]
        public string ProjectFloorName { get; set; }

        #endregion
    }
}