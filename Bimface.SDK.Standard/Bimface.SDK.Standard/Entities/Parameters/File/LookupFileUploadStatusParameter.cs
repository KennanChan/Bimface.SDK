#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.File
{
    [BimfaceFileHttpRequest(HttpMethods.Get, "/files/{fileId}/uploadStatus")]
    public class LookupFileUploadStatusParameter : FileParameter
    {
        #region Constructors

        public LookupFileUploadStatusParameter(long fileId) : base(fileId)
        {
        }

        #endregion
    }
}