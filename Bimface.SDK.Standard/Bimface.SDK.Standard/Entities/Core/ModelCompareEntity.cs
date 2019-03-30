#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class ModelCompareEntity
    {
        #region Properties

        [DataMember(Name = "compareId")]
        public long? CompareId { get; set; }

        [DataMember(Name = "createTime")]
        public DateTime CreateTime { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "priority")]
        public int? Priority { get; set; }

        [DataMember(Name = "reason")]
        public string Reason { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        [DataMember(Name = "status")]
        public string Status { get; set; }

        [DataMember(Name = "thumbnails")]
        public object[] Thumbnails { get; set; }

        #endregion
    }
}