#region

using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

#endregion

namespace Bimface.SDK.Requests.Compare
{
    internal class LookupCompareOfflineDatabagRequest : BimfaceCompareApiRequest
    {
        #region Constructors

        public LookupCompareOfflineDatabagRequest(LookupCompareOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Get, "/offlineDatabag")
        {
        }

        #endregion
    }
}