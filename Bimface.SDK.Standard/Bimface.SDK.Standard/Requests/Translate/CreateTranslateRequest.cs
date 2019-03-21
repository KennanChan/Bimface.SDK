using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Translate;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Translate
{
    internal class CreateTranslateRequest : BimfaceApiRequest
    {
        public CreateTranslateRequest(CreateTranslateParameter parameter) : base(HttpMethods.Put, "/translate")
        {
            AddJsonBody(parameter.Request);
        }
    }
}
