using Bimface.SDK.Entities.Parameters.Data.Compare;

namespace Bimface.SDK.Requests.Data.Compare
{
    internal class LookupCompareTreeRequest : BimfaceCompareDataApiRequest
    {
        public LookupCompareTreeRequest(LookupCompareTreeParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/tree", apiVersion)
        {
        }
    }
}
