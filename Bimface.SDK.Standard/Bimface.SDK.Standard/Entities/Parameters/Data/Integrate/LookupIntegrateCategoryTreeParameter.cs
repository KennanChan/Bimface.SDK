#region

using System.Collections.Generic;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/tree")]
    public class LookupIntegrateCategoryTreeParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateCategoryTreeParameter(long integrateId) : base(integrateId)
        {

        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public List<string> DesiredHierarchy { get; set; } = new List<string>();

        [HttpQueryComponent]
        public string TreeType { get; set; }

        [HttpBodyComponent]
        public IntegrationTreeOptionalRequest Request { get; set; }

        #endregion
    }
}