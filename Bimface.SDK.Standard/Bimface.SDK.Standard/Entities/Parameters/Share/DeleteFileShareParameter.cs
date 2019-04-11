#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    public class DeleteFileShareParameter : DeleteShareParameter
    {
        #region Constructors

        public DeleteFileShareParameter(long fileId)
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