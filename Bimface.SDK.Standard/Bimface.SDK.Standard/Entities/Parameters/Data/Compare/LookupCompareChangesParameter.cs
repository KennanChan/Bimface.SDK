using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Compare
{
    public class LookupCompareChangesParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareChangesParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Properties

        public string FollowingElementId { get; set; }
        public long? FollowingFileId { get; set; }
        public string PreviousElementId { get; set; }
        public long? PreviousFileId { get; set; }

        #endregion
    }
}