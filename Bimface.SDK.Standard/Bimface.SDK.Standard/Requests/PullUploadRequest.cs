using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal sealed class PullUploadRequest : BimfaceFileRequest
    {
        public PullUploadRequest(PullUploadParameter parameter) : base("/upload")
        {
            AddQuery("url", parameter.Url);
            AddQuery("name", parameter.Name);
            AddQuery("sourceId", parameter.SourceId);
            AddQuery("etag", parameter.Etag);
        }
    }
}