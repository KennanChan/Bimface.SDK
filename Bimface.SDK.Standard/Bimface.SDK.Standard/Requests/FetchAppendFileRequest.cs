using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class FetchAppendFileRequest : BimfaceFileRequest
    {
        public FetchAppendFileRequest(FetchAppendFileParameter parameter) : base(
            $"/appendFiles/{parameter.AppendFileId}")
        {
            Parameter = parameter;
        }

        private FetchAppendFileParameter Parameter { get; }
    }
}