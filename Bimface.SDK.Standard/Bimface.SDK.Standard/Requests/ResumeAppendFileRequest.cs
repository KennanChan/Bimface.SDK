using System.Net;
using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpJsonMime]
    internal class ResumeAppendFileRequest : BimfaceFileRequest
    {
        public ResumeAppendFileRequest(ResumeAppendFileParameter parameter) : base(HttpMethods.Post,
            $"/appendFiles/{parameter.AppendFileId}/data")
        {
            AddNullableQuery("position", parameter.Position);
        }
    }
}
