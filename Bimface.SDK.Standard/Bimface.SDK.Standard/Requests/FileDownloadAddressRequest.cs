using System.Net;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class FileDownloadAddressRequest : BimfaceFileRequest
    {
        public FileDownloadAddressRequest(FileDownloadAddressParameter parameter) : base(HttpMethods.Get, "/download/url")
        {
            AddNullableQuery("fileId", parameter.FileId);
            AddQuery("name", parameter.Name);
        }
    }
}