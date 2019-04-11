#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/floors")]
    public class ListIntegrateFloorsParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateFloorsParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public bool? IncludeArea { get; set; }

        [HttpQueryComponent]
        public bool? IncludeRoom { get; set; }

        #endregion
    }
}