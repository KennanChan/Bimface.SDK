namespace Bimface.SDK.Entities.Core
{
    public class ModelCompareItem
    {
        #region Properties

        public string FollowingDatabagId { get; set; }
        public long? FollowingFileId { get; set; }
        public string FollowingFileName { get; set; }
        public string PreviousDatabagId { get; set; }
        public long? PreviousFileId { get; set; }
        public string PreviousFileName { get; set; }

        #endregion
    }
}