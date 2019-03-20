namespace Bimface.SDK.Entities.Parameters
{
    public class ResumeAppendFileParameter
    {
        public ResumeAppendFileParameter(long? appendFileId, long position)
        {
            AppendFileId = appendFileId;
            Position = position;
        }

        #region Properties

        public long? AppendFileId { get; }
        public long? Position { get; }

        #endregion
    }
}