namespace Bimface.SDK.Entities.Parameters
{
    public abstract class FileParameter
    {
        protected FileParameter(long? fileId)
        {
            FileId = fileId;
        }
        public long? FileId { get; }
    }
}