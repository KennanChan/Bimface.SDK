using Bimface.SDK.Entities.Parameters.Data.File;

namespace Bimface.SDK.Requests.Data.File
{
    internal class ListFileFloorAreasRequest : BimfaceFileDataApiRequest
    {
        #region Constructors

        public ListFileFloorAreasRequest(ListFileFloorAreasParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/areas", apiVersion)
        {
            AddQuery("floorId", parameter.FloorId);
        }

        #endregion
    }
}