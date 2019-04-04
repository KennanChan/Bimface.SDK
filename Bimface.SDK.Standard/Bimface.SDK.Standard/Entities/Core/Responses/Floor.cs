using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Floor
    {
        [DataMember(Name = "archElev")]
        public float ArchtectureElevation { get; set; }

        [DataMember(Name = "areas")]
        public ObjectOnFloor[] Areas { get; set; }

        [DataMember(Name = "elevation")]
        public float Elevation { get; set; }

        [DataMember(Name = "height")]
        public float Height { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "miniMap")]
        public string MiniMap { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "rooms")]
        public ObjectOnFloor[] Rooms { get; set; }

        [DataMember(Name = "structElev")]
        public float StructureElevation { get; set; }
    }
}