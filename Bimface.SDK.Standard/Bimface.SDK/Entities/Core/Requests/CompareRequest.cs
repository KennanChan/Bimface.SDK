#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core.Requests
{
    [DataContract]
    public class CompareRequest
    {
        #region Properties

        [DataMember(Name = "callback")]
        public string Callback { get; set; }

        [DataMember(Name = "compareEntityType")]
        public string ComparedEntityType { get; set; }

        [DataMember(Name = "config")]
        public object Config { get; set; }

        [DataMember(Name = "followingId")]
        public long? FollowingId { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "previousId")]
        public long? PreviousId { get; set; }

        [DataMember(Name = "priority")]
        public int? Priority { get; set; }

        [DataMember(Name = "sourceId")]
        public string SourceId { get; set; }

        #endregion
    }
}