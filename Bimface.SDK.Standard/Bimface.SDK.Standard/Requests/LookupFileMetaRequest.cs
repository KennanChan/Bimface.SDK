using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpGet]
    internal class LookupFileMetaRequest : BimfaceFileRequest
    {
        public LookupFileMetaRequest(LookupFileMetaParameter parameter) : base("/metadata")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }
    }
}