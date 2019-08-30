#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Data.File
{
    [BimfaceDataApiHttpRequest("/files/{fileId}/commonElementProperties")]
    public class LookupFileElementsCommandPropertyParameter : FileParameter
    {
        #region Constructors

        public LookupFileElementsCommandPropertyParameter(long fileId, string[] elementIds) : base(fileId)
        {
            ElementIds = elementIds;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string[] ElementIds { get; }

        [HttpQueryComponent]
        public bool IncludeOverrides { get; set; }

        #endregion
    }
}