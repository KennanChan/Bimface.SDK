namespace Bimface.SDK.Entities.Parameters
{
    public abstract class FileParameter
    {
        #region Constructors

        protected FileParameter(long? fileId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        public long? FileId { get; }

        #endregion
    }
}