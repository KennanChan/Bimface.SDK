#region

using System.Runtime.Serialization;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Entities.Core.Responses
{
    [DataContract]
    public class CompareRequestEntity : ICallbackSource, IConfigurable
    {
        #region Properties

        [DataMember(Name = "callback")]
        public string Callback { get; set; }

        [DataMember(Name = "comparedEntityType")]
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