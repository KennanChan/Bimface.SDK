using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Compare
{
    internal class LookupCompareOfflineDatabagRequest : BimfaceCompareApiRequest
    {
        public LookupCompareOfflineDatabagRequest(LookupCompareOfflineDatabagParameter parameter)
            : base(parameter, HttpMethods.Get, "/offlineDatabag")
        {
        }
    }
}
