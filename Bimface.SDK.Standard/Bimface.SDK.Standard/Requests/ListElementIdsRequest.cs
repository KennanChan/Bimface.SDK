using Bimface.SDK.Entities.Parameters;

namespace Bimface.SDK.Requests
{
    internal class ListElementIdsRequest : BimfaceDataApiRequest
    {
        public ListElementIdsRequest(ListElementIdsParameter parameter, string version = "v2") : base($"/files/{parameter.FileId}/elementIds",
            version)
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