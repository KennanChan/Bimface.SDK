#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.View
{
    public class FetchFileViewTokenParameter : FetchViewTokenParameter
    {
        #region Constructors

        public FetchFileViewTokenParameter(long fileId)
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