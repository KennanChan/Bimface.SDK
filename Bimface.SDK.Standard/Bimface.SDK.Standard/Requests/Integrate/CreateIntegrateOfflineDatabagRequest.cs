#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Integrate
{
    internal class CreateIntegrateOfflineDatabagRequest : BimfaceIntegrateApiRequest
    {
        #region Constructors

        public CreateIntegrateOfflineDatabagRequest(CreateIntegrateOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Put, "/offlineDatabag")
        {
            AddQuery("callback", parameter.Callback);
            AddJsonBody(parameter.Request);
        }

        #endregion
    }
}