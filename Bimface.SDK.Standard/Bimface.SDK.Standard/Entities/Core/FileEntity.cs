#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class FileEntity
    {
        #region Properties

        [DataMember(Name = "createTime")] public DateTime CreateTime { get; set; }

        [DataMember(Name = "etag")] public string Etag { get; set; }

        [DataMember(Name = "fileId")] public long? FileId { get; set; }

        [DataMember(Name = "length")] public long? Length { get; set; }

        [DataMember(Name = "name")] public string Name { get; set; }

        [DataMember(Name = "status")] public string Status { get; set; }

        [DataMember(Name = "suffix")] public string Suffix { get; set; }

        #endregion
    }
}