#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.View
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/files/{fileId}/viewToken")]
    public class FetchIntegrateFileViewTokenParameter : IntegrateParameter
    {
        #region Constructors

        public FetchIntegrateFileViewTokenParameter(long integrateId, long fileId) : base(integrateId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public long FileId { get; }

        #endregion
    }
}