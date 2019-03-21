using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class LookupFileAreaRequest : BimfaceFileDataApiRequest
    {
        public LookupFileAreaRequest(LookupFileAreaParameter parameter, string version = "v2")
            : base(parameter, $"/areas/{parameter.AreaId}", version)
        {
        }
    }
}
