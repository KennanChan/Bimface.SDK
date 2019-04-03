#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Entities.Parameters.OfflineDatabag;

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