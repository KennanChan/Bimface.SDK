#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class InsecureShareLinkEntity
    {
        #region Properties

        [DataMember(Name = "appKey")]
        public string AppKey { get; set; }

        [DataMember(Name = "expireTime")]
        public DateTime ExpireTime { get; set; }

        [DataMember(Name = "passwordProtect")]
        public bool PasswordProtect { get; set; }

        [DataMember(Name = "sourceId")]
        public long? SourceId { get; set; }

        [DataMember(Name = "sourceType")]
        public string SourceType { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        #endregion
    }
}