#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.Translate
{
    [BimfaceAuth]
    [BimfaceApiHttpRequest(HttpMethods.Get, "/translate")]
    public class LookupTranslateParameter : HttpParameter
    {
        #region Constructors

        public LookupTranslateParameter(long fileId)
        {
            FileId = fileId;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public long FileId { get; }

        #endregion
    }
}