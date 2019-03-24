using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateFloorsRequest : BimfaceIntegrateDataApiRequest
    {
        public ListIntegrateFloorsRequest(ListIntegrateFloorsParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/floors", apiVersion)
        {
        }
    }
}
