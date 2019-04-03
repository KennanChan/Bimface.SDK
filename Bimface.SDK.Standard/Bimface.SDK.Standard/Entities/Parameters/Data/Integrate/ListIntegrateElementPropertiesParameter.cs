#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/elements/{elementId}")]
    public class ListIntegrateElementPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateElementPropertiesParameter(long integrateId, string elementId) : base(integrateId)
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