#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    public class LookupFileShareParameter : LookupShareParameter
    {
        #region Constructors

        public LookupFileShareParameter(long fileId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long FileId { get; set; }

        #endregion
    }
}