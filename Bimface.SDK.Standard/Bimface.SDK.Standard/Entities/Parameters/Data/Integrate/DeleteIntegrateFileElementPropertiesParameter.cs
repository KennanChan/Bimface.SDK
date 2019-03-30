#region

using System.Collections.Generic;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.Integrate
{
    public class DeleteIntegrateFileElementPropertiesParameter : IntegrateParameter
    {
        #region Constructors

        public DeleteIntegrateFileElementPropertiesParameter(long integrateId, string fileIdHash, string elementId) :
            base(integrateId)
        {
            FileIdHash = fileIdHash;
            ElementId  = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }

        public string              FileIdHash { get; }
        public List<PropertyGroup> Properties { get; set; } = new List<PropertyGroup>();

        #endregion
    }
}