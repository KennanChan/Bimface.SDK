using Bimface.SDK.Entities.Parameters.Data;

namespace Bimface.SDK.Requests.Data
{
    internal class ListFileElementIdsRequest : BimfaceFileDataApiRequest
    {
        public ListFileElementIdsRequest(ListFileElementIdsParameter parameter, string version = "v2")
            : base(parameter, "/elementIds", version)
        {
            AddNullableQuery("allNull", parameter.AllNull);
            AddQuery("categoryId", parameter.CategoryId);
            AddQuery("family", parameter.Family);
            AddQuery("familyType", parameter.FamilyType);
            AddQuery("floor", parameter.Floor);
            AddQuery("paginationContextId", parameter.PaginationContextId);
            AddNullableQuery("paginationNo", parameter.PaginationNo);
            AddNullableQuery("paginationSize", parameter.PaginationSize);
            AddQuery("roomId", parameter.RoomId);
            AddNullableQuery("roomToleranceXY", parameter.RoomToleranceXY);
            AddNullableQuery("roomToleranceXY", parameter.RoomToleranceXY);
            AddQuery("specialty", parameter.Specialty);
            AddQuery("systemType", parameter.SystemType);
        }
    }
}