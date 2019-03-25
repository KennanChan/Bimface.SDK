using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateElementPropertiesRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateElementPropertiesRequest(ListIntegrateElementPropertiesParameter parameter,
            string apiVersion = DefaultApiVersion)
            : base(parameter, $"/elements/{parameter.ElementId}", apiVersion)
        {
        }

        #endregion
    }
}