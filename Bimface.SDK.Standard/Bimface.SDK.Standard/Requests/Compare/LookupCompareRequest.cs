using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Requests.Base;

namespace Bimface.SDK.Requests.Compare
{
    internal class LookupCompareRequest : BimfaceCompareRequest
    {
        public LookupCompareRequest(LookupCompareParameter parameter, string apiVersion = DefaultApiVersion)
            : base(HttpMethods.Get, "", apiVersion)
        {
            AddQuery("compareId", parameter.CompareId);
        }
    }
}