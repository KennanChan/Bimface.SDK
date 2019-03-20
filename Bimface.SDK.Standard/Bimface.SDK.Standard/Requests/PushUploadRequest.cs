using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpPut]
    [HttpBinaryMime]
    internal sealed class PushUploadRequest : BimfaceFileRequest
    {
        public PushUploadRequest(PushUploadParameter parameter) : base("/upload")
        {
            SetContentLength(parameter.Stream.Length);
            AddQuery("name", parameter.Name);
            AddQuery("sourceId", parameter.SourceId);
            AddBody(parameter.Stream);
        }
    }
}