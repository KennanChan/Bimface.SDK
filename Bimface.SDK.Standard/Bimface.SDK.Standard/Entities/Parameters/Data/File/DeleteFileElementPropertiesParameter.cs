#region

using System.Collections.Generic;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/elements/{elementId}/properties", Method = HttpMethods.Delete)]
    public class DeleteFileElementPropertiesParameter : FileParameter
    {
        #region Constructors

        public DeleteFileElementPropertiesParameter(long fileId, string elementId) : base(fileId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string ElementId { get; }

        [HttpBodyComponent]
        public List<PropertyGroup> Properties { get; set; } = new List<PropertyGroup>();

        #endregion
    }
}