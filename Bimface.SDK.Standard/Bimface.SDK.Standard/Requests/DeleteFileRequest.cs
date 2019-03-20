using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpDelete]
    internal class DeleteFileRequest : BimfaceFileRequest
    {
        public DeleteFileRequest(DeleteFileParameter parameter) : base("/file")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }
    }
}
