#region

using System.IO;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Post, "/appendFiles/{appendFileId}/data")]
    public class ResumeAppendFileParameter : HttpParameter
    {
        #region Constructors

        public ResumeAppendFileParameter(long appendFileId, long position, Stream stream)
        {
            AppendFileId = appendFileId;
            Position     = position;
            Stream       = stream;
        }

        #endregion

        #region Properties

        [HttpPathComponent]
        public long AppendFileId { get; }

        [HttpQueryComponent]
        public long Position { get; }

        [HttpBodyComponent(HttpContentType.Binary)]
        public Stream Stream { get; }

        #endregion
    }
}