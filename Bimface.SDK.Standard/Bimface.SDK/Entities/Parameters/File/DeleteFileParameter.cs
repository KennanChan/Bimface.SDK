#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceAuth]
    [BimfaceFileHttpRequest(HttpMethods.Delete, "/file")]
    public class DeleteFileParameter : HttpParameter
    {
        #region Constructors

        public DeleteFileParameter(long fileId)
        {
            FileId = fileId;
        }

        [HttpQueryComponent]
        public long FileId { get; }

        #endregion
    }
}