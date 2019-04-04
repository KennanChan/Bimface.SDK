using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class TreeNode
    {
        [DataMember(Name = "actualName")]
        public string ActualName { get; set; }

        [DataMember(Name = "data")]
        public object Data { get; set; }

        [DataMember(Name = "elementCount")]
        public int? ElementCount { get; set; }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "items")]
        public TreeNode[] Items { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }
    }
}