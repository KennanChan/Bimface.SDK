#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceFileHttpRequest(HttpMethods.Delete, "/file")]
    public class DeleteFileParameter : FileParameter
    {
        #region Constructors

        public DeleteFileParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}