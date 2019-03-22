#region

using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateElementsCommonPropertiesParameter : IntegrateParameter
    {
        public ListIntegrateElementsCommonPropertiesParameter(long integrateId) : base(integrateId)
        {
        }

        public bool?                             IncludeOverrides             { get; set; }
        public FileIdHashWithElementIdsRequest[] FileIdHashWithElementIdsList { get; set; }
    }
}