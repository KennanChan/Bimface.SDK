#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Integrate
{
    internal class LookupIntegrateOfflineDatabagRequest : BimfaceIntegrateApiRequest
    {
        #region Constructors

        public LookupIntegrateOfflineDatabagRequest(LookupIntegrateOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Get, "/offlineDatabag")
        {
        }

        #endregion
    }
}