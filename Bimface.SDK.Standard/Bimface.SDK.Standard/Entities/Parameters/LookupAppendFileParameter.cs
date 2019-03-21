namespace Bimface.SDK.Entities.Parameters
{
    public class LookupAppendFileParameter
    {
        #region Constructors

        public LookupAppendFileParameter(long? appendFileId)
        {
            AppendFileId = appendFileId;
        }

        #endregion

        #region Properties

        public long? AppendFileId { get; }

        #endregion
    }
}