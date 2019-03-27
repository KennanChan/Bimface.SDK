using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Compare
{
    internal class CreateCompareOfflineDatabagRequest : BimfaceCompareApiRequest
    {
        public CreateCompareOfflineDatabagRequest(CreateCompareOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Put, "/offlineDatabag")
        {
            AddQuery("callback", parameter.Callback);
            AddJsonBody(parameter.Request);
        }
    }
}
