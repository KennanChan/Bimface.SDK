using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.File;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.File
{
    [BimfaceAuth]
    internal class LookupAppendFileRequest : BimfaceFileRequest
    {
        public LookupAppendFileRequest(LookupAppendFileParameter parameter) : base(HttpMethods.Get,
            $"/appendFiles/{parameter.AppendFileId}")
        {

        }
    }
}