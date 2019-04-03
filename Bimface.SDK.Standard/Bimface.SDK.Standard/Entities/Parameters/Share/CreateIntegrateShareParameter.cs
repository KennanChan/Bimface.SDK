#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    public class CreateIntegrateShareParameter : CreateShareParameter
    {
        #region Constructors

        public CreateIntegrateShareParameter(long integrateId)
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