#region

using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class FileTreeRequest
    {
        #region Properties

        [DataMember(Name = "customizedNodeKeys")]
        public Dictionary<string, string> CustomizedNodeKeys { get; set; }

        [DataMember(Name = "desiredHierarchy")]
        public List<object> DesiredHierarchy { get; set; }

        #endregion
    }
}