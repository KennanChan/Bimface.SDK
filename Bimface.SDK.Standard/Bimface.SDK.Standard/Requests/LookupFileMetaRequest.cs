using System.Net;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
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