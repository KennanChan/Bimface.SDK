#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    public class DeleteIntegrateShareParameter : DeleteShareParameter
    {
        #region Constructors

        public DeleteIntegrateShareParameter(long integrateId)
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