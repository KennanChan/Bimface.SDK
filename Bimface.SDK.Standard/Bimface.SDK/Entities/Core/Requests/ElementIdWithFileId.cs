#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class ElementIdWithFileId
    {
        #region Properties

        [DataMember(Name = "elementId")]
        public string ElementId { get; set; }

        [DataMember(Name = "fileId")]
        public string FileId { get; set; }

        #endregion
    }
}