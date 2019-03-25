namespace Bimface.SDK.Entities.Parameters.File
{
    public class ResumeAppendFileParameter
    {
        #region Constructors

        public ResumeAppendFileParameter(long? appendFileId, long position)
        {
            AppendFileId = appendFileId;
            Position = position;
        }

        #endregion

        #region Properties

        public long? AppendFileId { get; }
        public long? Position { get; }

        #endregion
    }
}