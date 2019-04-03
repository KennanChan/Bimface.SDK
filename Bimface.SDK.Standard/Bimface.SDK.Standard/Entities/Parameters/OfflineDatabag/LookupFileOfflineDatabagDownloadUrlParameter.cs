#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    public class LookupFileOfflineDatabagDownloadUrlParameter : LookupOfflineDatabagDownloadUrlParameter
    {
        #region Constructors

        public LookupFileOfflineDatabagDownloadUrlParameter(long fileId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long FileId { get; }

        #endregion
    }
}