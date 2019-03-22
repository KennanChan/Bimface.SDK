#region

using System.Collections.Generic;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    public class FileTreeRequest
    {
        public Dictionary<string, string> CustomizedNodeKeys { get; set; }
        public List<object>               DesiredHierarchy   { get; set; }
    }
}