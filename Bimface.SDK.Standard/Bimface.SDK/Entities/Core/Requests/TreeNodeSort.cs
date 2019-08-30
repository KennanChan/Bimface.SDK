using System.Runtime.Serialization;

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class TreeNodeSort
    {
        #region Properties

        [DataMember(Name = "nodeType")]
        public NodeType NodeType { get; set; }

        [DataMember(Name = "sortBy")]
        public string SortBy { get; set; }

        [DataMember(Name = "sortedValues")]
        public string[] SortedValues { get; set; }

        #endregion
    }
}