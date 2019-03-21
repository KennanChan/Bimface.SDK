using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    [BimfaceAuth]
    internal class CreateAppendFileRequest : BimfaceFileRequest
    {
        public CreateAppendFileRequest(CreateAppendFileParameter parameter) : base(HttpMethods.Post, "/appendFiles")
        {
            AddQuery("name", parameter.Name);
            AddNullableQuery("length", parameter.Length);
            AddQuery("sourceId", parameter.SourceId);
        }
    }
}