using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Tree
    {
        [DataMember(Name = "items")]
        public TreeNode[] Items { get; set; }

        [DataMember(Name = "root")]
        public string Root { get; set; }
    }
}
