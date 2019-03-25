#region

using System.Runtime.Serialization;

#endregion

namespace Bimface.SDK.Entities.Core
{
    [DataContract]
    public class ModelCompareItem
    {
        #region Properties

        [DataMember(Name = "followingDatabagId")]
        public string FollowingDatabagId { get; set; }

        [DataMember(Name = "followingFileId")] public long? FollowingFileId { get; set; }

        [DataMember(Name = "followingFileName")]
        public string FollowingFileName { get; set; }

        [DataMember(Name = "previousDatabagId")]
        public string PreviousDatabagId { get; set; }

        [DataMember(Name = "previousFileId")] public long? PreviousFileId { get; set; }

        [DataMember(Name = "previousFileName")]
        public string PreviousFileName { get; set; }

        #endregion
    }
}