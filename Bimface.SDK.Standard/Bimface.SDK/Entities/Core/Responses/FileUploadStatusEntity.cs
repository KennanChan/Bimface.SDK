#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class FileUploadStatusEntity
    {
        #region Properties

        [DataMember(Name = "failedReason")]
        public string FailedReason { get; set; }

        [DataMember(Name = "fileId")]
        public long? FileId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        #endregion
    }
}