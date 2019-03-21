using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
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