#region

using System;
using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class InsecureShareLinkEntity
    {
        #region Fields

        private DateTime? _expireTime;

        #endregion

        #region Properties

        [DataMember(Name = "appKey")]
        public string AppKey { get; set; }

        public DateTime? ExpireTime => _expireTime ?? (_expireTime = DateTime.Parse(ExpireTimeString));

        [DataMember(Name = "expireTime")]
        public string ExpireTimeString { get; set; }

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