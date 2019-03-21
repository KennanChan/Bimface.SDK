namespace Bimface.SDK.Entities.Parameters.Base
{
    public abstract class FileParameter
    {
        #region Constructors

        protected FileParameter(long fileId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        public long? FileId { get; }

        #endregion
    }
}