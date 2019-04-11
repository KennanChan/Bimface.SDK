#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.View
{
    public class FetchIntegrateViewTokenParameter : FetchViewTokenParameter
    {
        #region Constructors

        public FetchIntegrateViewTokenParameter(long integrateId)
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