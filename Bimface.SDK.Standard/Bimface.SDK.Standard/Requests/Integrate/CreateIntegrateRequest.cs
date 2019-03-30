#region

using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Integrate
{
    [BimfaceAuth]
    internal class CreateIntegrateRequest : BimfaceApiRequest
    {
        #region Constructors

        public CreateIntegrateRequest(CreateIntegrateParameter parameter) : base(HttpMethods.Put, "/integrate")
        {
            AddJsonBody(parameter.Request);
        }

        #endregion
    }
}