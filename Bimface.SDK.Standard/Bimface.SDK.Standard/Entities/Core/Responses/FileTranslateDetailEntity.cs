#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class FileTranslateDetailEntity
    {
        #region Properties

        [DataMember(Name = "appKey")]
        public string AppKey { get; set; }

        [DataMember(Name = "cost")]
        public int? Cost { get; set; }

        [DataMember(Name = "createTime")]
        public DateTime CreateTime { get; set; }

        [DataMember(Name = "databagId")]
        public string DatabagId { get; set; }

        [DataMember(Name = "fileId")]
        public long? FileId { get; set; }

        [DataMember(Name = "length")]
        public long? Length { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "offlineDatabagStatus")]
        public string OfflineDatabagStatus { get; set; }

        [DataMember(Name = "priority")]
        public int? Priority { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }

        [DataMember(Name = "retry")]
        public bool Retry { get; set; }

        [DataMember(Name = "shareToken")]
        public string ShareToken { get; set; }

        [DataMember(Name = "shareUrl")]
        public string ShareUrl { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "supportOfflineDatabag")]
        public bool SupportOfflineDatabag { get; set; }

        [DataMember(Name = "thumbnail")]
        public string[] Thumbnails { get; set; }

        [DataMember(Name = "type")]
        public string Type { get; set; }

        #endregion
    }
}