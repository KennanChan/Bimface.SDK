using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class DeleteFileRequest : BimfaceFileRequest
    {
        public DeleteFileRequest(DeleteFileParameter parameter) : base(HttpMethods.Delete, "/file")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }
    }
}