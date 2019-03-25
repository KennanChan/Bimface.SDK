using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class DeleteFileRequest : BimfaceFileRequest
    {
        #region Constructors

        public DeleteFileRequest(DeleteFileParameter parameter) : base(HttpMethods.Delete, "/file")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }

        #endregion
    }
}