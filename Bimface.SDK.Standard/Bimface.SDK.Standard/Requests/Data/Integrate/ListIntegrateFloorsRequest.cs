#region

using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateFloorsRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateFloorsRequest(ListIntegrateFloorsParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/floors", apiVersion)
        {
        }

        #endregion
    }
}