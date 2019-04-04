#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/commonElementProperties")]
    public class LookupIntegrateElementsCommonPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateElementsCommonPropertiesParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        [HttpBodyComponent]
        public FileIdHashWithElementIdsRequest[] FileIdHashWithElementIdsList { get; set; }

        [HttpQueryComponent]
        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}