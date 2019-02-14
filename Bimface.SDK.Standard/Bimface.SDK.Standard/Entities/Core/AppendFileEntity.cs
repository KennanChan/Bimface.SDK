#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class AppendFileEntity
    {
        #region Properties

        [DataMember(Name = "appendFileId")]
        public long? AppendFileId { get; set; }

        [DataMember(Name = "createTime")]
        public DateTime CreateTime { get; set; }

        [DataMember(Name = "file")]
        public FileEntity File { get; set; }

        [DataMember(Name = "length")]
        public long? Length { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "position")]
        public long? Position { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        #endregion
    }
}