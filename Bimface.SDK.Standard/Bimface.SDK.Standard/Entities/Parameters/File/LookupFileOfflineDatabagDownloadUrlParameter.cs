#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    public class LookupFileOfflineDatabagDownloadUrlParameter : FileParameter
    {
        #region Constructors

        public LookupFileOfflineDatabagDownloadUrlParameter(long fileId) : base(fileId)
        {
        }

        #endregion

        #region Properties

        public string DatabagVersion { get; set; }
        public string Type           { get; set; }

        #endregion
    }
}