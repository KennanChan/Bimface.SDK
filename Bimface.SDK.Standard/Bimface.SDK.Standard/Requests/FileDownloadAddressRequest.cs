using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpGet]
    internal class FileDownloadAddressRequest : BimfaceFileRequest
    {
        public FileDownloadAddressRequest(FileDownloadAddressParameter parameter) : base("/download/url")
        {
            AddNullableQuery("fileId", parameter.FileId);
            AddQuery("name", parameter.Name);
        }
    }
}
