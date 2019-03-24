using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class LookupIntegrateAreaRequest : BimfaceIntegrateDataApiRequest
    {
        public LookupIntegrateAreaRequest(LookupIntegrateAreaParameter parameter, string apiVersion)
            : base(parameter, $"/areas/{parameter.AreaId}", apiVersion)
        {
        }
    }
}
