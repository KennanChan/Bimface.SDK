#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    public class LookupIntegrateOfflineDatabagDownloadUrlParameter : LookupOfflineDatabagDownloadUrlParameter
    {
        #region Constructors

        public LookupIntegrateOfflineDatabagDownloadUrlParameter(long integrateId)
        {
            IntegrateId = integrateId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long IntegrateId { get; }

        #endregion
    }
}