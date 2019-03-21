using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.File
{
    public class FileDownloadAddressParameter : FileParameter
    {
        #region Constructors

        public FileDownloadAddressParameter(long fileId) : base(fileId)
        {
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        #endregion
    }
}