#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateElementsPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public ListIntegrateElementsPropertiesParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion

        #region Properties

        public FileIdHashWithElementIdsRequest[] FileIdHashWithElementIdsList { get; set; }

        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}