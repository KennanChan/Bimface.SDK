using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Integrate
{
    internal class LookupIntegrateOfflineDatabagRequest : BimfaceIntegrateApiRequest
    {
        public LookupIntegrateOfflineDatabagRequest(LookupIntegrateOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Get, "/offlineDatabag")
        {
        }
    }
}
