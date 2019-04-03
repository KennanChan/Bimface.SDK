#region

using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Core.Requests;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Entities.Parameters.OfflineDatabag
{
    [BimfaceApiHttpRequest(HttpMethods.Put, "/integrations/{integrateId}/offlineDatabag")]
    public class CreateIntegrateOfflineDatabagParameter : IntegrateParameter
    {
        #region Constructors

        public CreateIntegrateOfflineDatabagParameter(long integrateId, string callback, DatabagDerivativeRequest request)
            : base(integrateId)
        {
            Callback = callback;
            Request  = request;
        }

        #endregion

        #region Properties

        [HttpQueryComponent]
        public string Callback { get; }

        [HttpBodyComponent]
        public DatabagDerivativeRequest Request { get; }

        #endregion
    }
}