using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    internal class LookupTranslateRequest : BimfaceApiRequest
    {
        public LookupTranslateRequest(LookupTranslateParameter parameter) : base(HttpMethods.Get, "/translate")
        {
            AddNullableQuery("fileId", parameter.FileId);
        }
    }
}
