#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    [BimfaceApiHttpRequest(HttpMethods.Get, "/integrations/{integrateId}/offlineDatabag")]
    public class LookupIntegrateOfflineDatabagParameter : IntegrateParameter
    {
        #region Constructors

        public LookupIntegrateOfflineDatabagParameter(long integrateId) : base(integrateId)
        {
        }

        #endregion
    }
}