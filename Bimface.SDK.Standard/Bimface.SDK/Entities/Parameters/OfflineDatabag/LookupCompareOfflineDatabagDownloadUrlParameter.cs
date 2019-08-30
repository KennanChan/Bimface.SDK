#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    public class LookupCompareOfflineDatabagDownloadUrlParameter : LookupOfflineDatabagDownloadUrlParameter
    {
        #region Constructors

        public LookupCompareOfflineDatabagDownloadUrlParameter(long compareId)
        {
            CompareId = compareId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long CompareId { get; }

        #endregion
    }
}