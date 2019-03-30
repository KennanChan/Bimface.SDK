#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class FileDownloadAddressRequest : BimfaceFileRequest
    {
        #region Constructors

        public FileDownloadAddressRequest(FileDownloadAddressParameter parameter) : base(HttpMethods.Get,
            "/download/url")
        {
            AddNullableQuery("fileId", parameter.FileId);
            AddQuery("name", parameter.Name);
        }

        #endregion
    }
}