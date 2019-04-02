using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Post, "/appendFiles/:appendFileId/data")]
    public class ResumeAppendFileParameter : HttpParameter
    {
        #region Constructors

        public ResumeAppendFileParameter(long? appendFileId, long position)
        {
            AppendFileId = appendFileId;
            Position     = position;
        }

        #endregion

        #region Properties

        [HttpPathComponent(Alias = "appendFileId")]
        public long? AppendFileId { get; }

        [HttpQueryComponent(Alias = "position")]
        public long? Position { get; }

        #endregion
    }
}