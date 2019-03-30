#region

using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Integrate
{
    public class LookupIntegrateOfflineDatabagDownloadUrlParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateOfflineDatabagDownloadUrlParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        public string DatabagVersion { get; set; }
        public string Type           { get; set; }

        #endregion
    }
}