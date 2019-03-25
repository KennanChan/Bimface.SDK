using System.Collections.Generic;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class ModifyIntegrateFileElementPropertiesParameter : IntegrateParameter
    {
        public ModifyIntegrateFileElementPropertiesParameter(long integrateId, string fileIdHash, string elementId) : base(integrateId)
        {
            FileIdHash = fileIdHash;
            ElementId  = elementId;
        }

        public string              FileIdHash { get; }
        public string              ElementId  { get; }
        public List<PropertyGroup> Properties { get; set; } = new List<PropertyGroup>();
    }
}