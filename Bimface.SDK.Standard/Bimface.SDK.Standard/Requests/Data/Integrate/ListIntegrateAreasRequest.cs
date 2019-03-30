#region

using Bimface.SDK.Entities.Parameters.Data.Integrate;

#endregion

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateAreasRequest : BimfaceIntegrateDataApiRequest
    {
        #region Constructors

        public ListIntegrateAreasRequest(ListIntegrateAreasParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/areas", apiVersion)
        {
            AddQuery("floorId", parameter.FloorId);
        }

        #endregion
    }
}