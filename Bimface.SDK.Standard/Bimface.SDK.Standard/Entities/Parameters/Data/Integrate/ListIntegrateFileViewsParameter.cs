#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/fileViews")]
    public class ListIntegrateFileViewsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFileViewsParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string ViewType { get; set; }

        #endregion
    }
}