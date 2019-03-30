#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Integrate
{
    internal class LookupIntegrateRequest : BimfaceApiRequest
    {
        #region Constructors

        public LookupIntegrateRequest(LookupIntegrateParameter parameter) : base(HttpMethods.Get, "/integrate")
        {
            AddQuery("integrateId", parameter.IntegrateId);
        }

        #endregion
    }
}