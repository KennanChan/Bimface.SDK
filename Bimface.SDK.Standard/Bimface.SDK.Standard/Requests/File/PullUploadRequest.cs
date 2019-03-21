using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal sealed class PullUploadRequest : BimfaceFileRequest
    {
        public PullUploadRequest(PullUploadParameter parameter) : base(HttpMethods.Put, "/upload")
        {
            AddQuery("url", parameter.Url);
            AddQuery("name", parameter.Name);
            AddQuery("sourceId", parameter.SourceId);
            AddQuery("etag", parameter.Etag);
        }
    }
}