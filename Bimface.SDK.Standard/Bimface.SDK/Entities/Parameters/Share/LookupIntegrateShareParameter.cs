#region

using Bimface.SDK.Attributes.Http;

#endregion

namespace Bimface.SDK.Entities.Parameters.Share
{
    public class LookupIntegrateShareParameter : LookupShareParameter
    {
        #region Constructors

        public LookupIntegrateShareParameter(long integrateId)
        {
            IntegrateId = integrateId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long IntegrateId { get; set; }

        #endregion
    }
}