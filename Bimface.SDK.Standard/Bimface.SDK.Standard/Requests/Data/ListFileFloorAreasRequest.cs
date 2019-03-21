using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileFloorAreasRequest : BimfaceFileDataApiRequest
    {
        public ListFileFloorAreasRequest(ListFileFloorAreasParameter parameter, string version = "v2")
            : base(parameter, "/areas", version)
        {
            AddQuery("floorId", parameter.FloorId);
        }
    }
}