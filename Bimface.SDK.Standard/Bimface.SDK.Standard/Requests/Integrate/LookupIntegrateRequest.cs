using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Integrate
{
    internal class LookupIntegrateRequest : BimfaceApiRequest
    {
        public LookupIntegrateRequest(LookupIntegrateParameter parameter) : base(HttpMethods.Get, "/integrate")
        {
            AddQuery("integrateId", parameter.IntegrateId);
        }
    }
}
