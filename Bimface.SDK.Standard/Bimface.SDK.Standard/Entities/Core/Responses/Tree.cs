#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class Tree
    {
        #region Properties

        [DataMember(Name = "items")]
        public TreeNode[] Items { get; set; }

        [DataMember(Name = "root")]
        public string Root { get; set; }

        #endregion
    }
}