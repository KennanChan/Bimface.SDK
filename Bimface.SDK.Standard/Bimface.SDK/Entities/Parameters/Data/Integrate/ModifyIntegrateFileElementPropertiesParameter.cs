#region

using System.Collections.Generic;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    [BimfaceDataApiHttpRequest("/integrations/{integrateId}/files/{fileIdHash}/elements/{elementId}/properties", Method = HttpMethods.Put)]
    public class ModifyIntegrateFileElementPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public ModifyIntegrateFileElementPropertiesParameter(long integrateId, string fileIdHash, string elementId) :
            base(integrateId)
        {
            FileIdHash = fileIdHash;
            ElementId  = elementId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string ElementId { get; }

        [HttpPathComponent]
        public string FileIdHash { get; }

        [HttpBodyComponent]
        public List<PropertyGroup> Properties { get; set; } = new List<PropertyGroup>();

        #endregion
    }
}