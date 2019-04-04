#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/elements/{elementId}")]
    public class LookupFileElementPropertyParameter : FileParameter
    {
        #region Constructors

        public LookupFileElementPropertyParameter(long fileId, string elementId) : base(fileId)
        {
            ElementId = elementId;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public string ElementId { get; }

        [HttpQueryComponent]
        public bool? IncludeOverrides { get; set; }

        #endregion
    }
}