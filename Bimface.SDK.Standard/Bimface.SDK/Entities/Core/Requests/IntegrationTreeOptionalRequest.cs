#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class IntegrationTreeOptionalRequest
    {
        #region Properties

        [DataMember(Name = "customizedNodeKeys")]
        public Dictionary<string, string> CustomizedNodeKeys { get; set; }

        [DataMember(Name = "fileIdElementIds")]
        public List<ElementIdWithFileId> FileIdWithElementIds { get; set; }

        [DataMember(Name = "sortedNamesHierarchy")]
        public List<List<string>> SortedNamesHierarchy { get; set; }

        [DataMember(Name = "sorts")]
        public List<TreeNodeSort> Sorts { get; set; }

        #endregion
    }
}