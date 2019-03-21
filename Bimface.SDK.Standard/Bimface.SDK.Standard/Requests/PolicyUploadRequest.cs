using System.Net;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class PolicyUploadRequest : BimfaceFileRequest
    {
        public PolicyUploadRequest(PolicyUploadParameter parameter) : base(HttpMethods.Get, "/upload/policy")
        {
            AddQuery("name", parameter.Name);
            AddQuery("sourceId", parameter.SourceId);
        }
    }
}
