using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class LookupFileMetaRequest : BimfaceFileRequest
    {
        public LookupFileMetaRequest(LookupFileMetaParameter parameter) : base(HttpMethods.Get, "/metadata")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }
    }
}