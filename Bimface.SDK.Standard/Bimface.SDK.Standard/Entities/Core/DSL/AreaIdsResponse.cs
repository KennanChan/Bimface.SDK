using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.DSL
{
    [DataContract]
    public class AreaIdsResponse
    {
        [DataMember(Name = "areaIds")]
        public object[] AreaIds { get; set; }

        [DataMember(Name = "targetId")]
        public string TargetId { get; set; }
    }
}