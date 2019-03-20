using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpGet]
    internal class PolicyUploadRequest : BimfaceFileRequest
    {
        public PolicyUploadRequest(PolicyUploadParameter parameter) : base("/upload/policy")
        {
            AddQuery("name", parameter.Name);
            AddQuery("sourceId", parameter.SourceId);
        }
    }
}
