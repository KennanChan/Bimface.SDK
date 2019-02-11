namespace Bimface.SDK.Entities.Parameters
{
    public class FileDownloadAddressParameter : FileParameter
    {
        #region Constructors

        public FileDownloadAddressParameter(long? fileId) : base(fileId)
        {
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        #endregion
    }
}