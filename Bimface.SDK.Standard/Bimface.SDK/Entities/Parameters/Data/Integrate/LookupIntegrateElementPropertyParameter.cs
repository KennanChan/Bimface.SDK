#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/elements/{elementId}")]
    public class LookupIntegrateElementPropertyParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateElementPropertyParameter(long integrateId, string elementId) : base(integrateId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string ElementId { get; }

        #endregion
    }
}