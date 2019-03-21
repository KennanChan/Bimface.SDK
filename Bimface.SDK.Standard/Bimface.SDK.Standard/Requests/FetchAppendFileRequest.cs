using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class FetchAppendFileRequest : BimfaceFileRequest
    {
        public FetchAppendFileRequest(FetchAppendFileParameter parameter) : base(HttpMethods.Get,
            $"/appendFiles/{parameter.AppendFileId}")
        {

        }
    }
}