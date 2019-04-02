using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Get, "/appendFiles/:appendFileId")]
    public class LookupAppendFileParameter : HttpParameter
    {
        #region Constructors

        public LookupAppendFileParameter(long? appendFileId)
        {
            AppendFileId = appendFileId;
        }

        #endregion

        #region Properties

        [HttpPathComponent(Alias = "appendFileId")]
        public long? AppendFileId { get; }

        #endregion
    }
}