#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/elements/boundingboxes", null)]
    public class ListIntegrateElementsBoundingBoxParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateElementsBoundingBoxParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion
    }
}