using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    internal class CreateTranslateRequest : BimfaceApiRequest
    {
        public CreateTranslateRequest(CreateTranslateParameter parameter) : base(HttpMethods.Put, "/translate")
        {
            AddJsonBody(parameter.Request);
        }
    }
}
