using Bimface.SDK.Attributes;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    [HttpPost]
    internal class CreateAppendFileRequest : BimfaceFileRequest
    {
        public CreateAppendFileRequest(CreateAppendFileParameter parameter) : base("/appendFiles")
        {
            AddQuery("name", parameter.Name);
            AddNullableQuery("length", parameter.Length);
            AddQuery("sourceId", parameter.SourceId);
        }
    }
}