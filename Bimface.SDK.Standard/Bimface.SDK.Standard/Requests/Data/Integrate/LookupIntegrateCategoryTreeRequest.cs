using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class LookupIntegrateCategoryTreeRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public LookupIntegrateCategoryTreeRequest(LookupIntegrateCategoryTreeParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, $"/rooms/{parameter.RoomId}", apiVersion)
        {
        }

        #endregion
    }
}