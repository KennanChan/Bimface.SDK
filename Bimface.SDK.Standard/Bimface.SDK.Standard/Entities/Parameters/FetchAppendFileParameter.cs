namespace Bimface.SDK.Entities.Parameters
{
    public class FetchAppendFileParameter
    {
        #region Constructors

        public FetchAppendFileParameter(long? appendFileId)
        {
            AppendFileId = appendFileId;
        }

        #endregion

        #region Properties

        public long? AppendFileId { get; }

        #endregion
    }
}