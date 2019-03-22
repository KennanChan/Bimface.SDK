using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Integrate
{
    [BimfaceAuth]
    internal class DeleteIntegrateRequest : BimfaceApiRequest
    {
        public DeleteIntegrateRequest(DeleteIntegrateParameter parameter) : base(HttpMethods.Delete, "/integrate")
        {
            AddQuery("integrateId", parameter.IntegrateId);
        }
    }
}
