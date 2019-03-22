using System;
using System.Collections.Generic;
using System.Text;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ListIntegrateElementsPropertiesParameter : IntegrateParameter
    {
        public ListIntegrateElementsPropertiesParameter(long integrateId) : base(integrateId)
        {
        }

        public bool?                             IncludeOverrides             { get; set; }
        public FileIdHashWithElementIdsRequest[] FileIdHashWithElementIdsList { get; set; }
    }
}