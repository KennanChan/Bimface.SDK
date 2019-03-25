using System.Collections.Generic;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    public class ModifyFileElementPropertiesParameter : FileParameter
    {
        #region Constructors

        public ModifyFileElementPropertiesParameter(long fileId, string elementId) : base(fileId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        public string ElementId { get; }
        public List<PropertyGroup> Properties { get; set; } = new List<PropertyGroup>();

        #endregion
    }
}