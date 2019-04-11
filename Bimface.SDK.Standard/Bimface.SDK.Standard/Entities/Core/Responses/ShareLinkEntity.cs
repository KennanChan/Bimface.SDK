#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class ShareLinkEntity
    {
        #region Properties

        [DataMember(Name = "appKey")]
        public string AppKey { get; set; }

        [DataMember(Name = "expireTime")]
        public string ExpireTime { get; set; }

        [DataMember(Name = "password")]
        public string Password { get; set; }

        [DataMember(Name = "sourceId")]
        public long? SourceId { get; set; }

        [DataMember(Name = "sourceName")]
        public string SourceName { get; set; }

        [DataMember(Name = "sourceType")]
        public string SourceType { get; set; }

        [DataMember(Name = "url")]
        public string Url { get; set; }

        #endregion
    }
}