using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    [HttpBinaryMime]
    internal sealed class PushUploadRequest : BimfaceFileRequest
    {
        public PushUploadRequest(PushUploadParameter parameter) : base(HttpMethods.Put, "/upload")
        {
            SetContentLength(parameter.Stream.Length);
            AddQuery("name", parameter.Name);
            AddQuery("sourceId", parameter.SourceId);
            AddBody(parameter.Stream);
        }
    }
}