using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Compare
{
    public class LookupCompareOfflineDatabagDownloadUrlParameter : CompareParameter
    {
        #region Constructors

        public LookupCompareOfflineDatabagDownloadUrlParameter(long compareId) : base(compareId)
        {
        }

        #endregion

        #region Properties

        public string DatabagVersion { get; set; }
        public string Type { get; set; }

        #endregion
    }
}