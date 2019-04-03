using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.DSL
{
    [DataContract]
    public class RoomIdsResponse
    {
        [DataMember(Name = "roomIds")]
        public object[] RoomIds { get; set; }

        [DataMember(Name = "targetId")]
        public string TargetId { get; set; }
    }
}