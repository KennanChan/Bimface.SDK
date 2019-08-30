#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    public class CreateFileShareParameter : CreateShareParameter
    {
        #region Constructors

        public CreateFileShareParameter(long fileId)
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