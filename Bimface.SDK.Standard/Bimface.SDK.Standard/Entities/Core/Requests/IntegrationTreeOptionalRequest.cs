using System.Collections.Generic;

namespace Bimface.SDK.Entities.Core.Requests
{
    public class IntegrationTreeOptionalRequest
    {
        #region Properties

        public Dictionary<string, string> CustomizedNodeKeys { get; set; }
        public List<ElementIdWithFileId> ElementIdWithFileIds { get; set; }
        public List<List<string>> SortedNamesHierarchy { get; set; }

        #endregion
    }
}