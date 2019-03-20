using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpPost]
    [HttpJsonMime]
    internal class ResumeAppendFileRequest : BimfaceFileRequest
    {
        public ResumeAppendFileRequest(ResumeAppendFileParameter parameter) : base(
            $"/appendFiles/{parameter.AppendFileId}/data")
        {
            AddNullableQuery("position", parameter.Position);
        }
    }
}
