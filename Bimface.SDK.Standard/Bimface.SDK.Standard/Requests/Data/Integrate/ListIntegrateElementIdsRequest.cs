using Bimface.SDK.Entities.Parameters.Data.Integrate;

namespace Bimface.SDK.Requests.Data.Integrate
{
    internal class ListIntegrateElementIdsRequest : BimfaceIntegrateDataApiRequest
    {
        public ListIntegrateElementIdsRequest(ListIntegrateElementIdsParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/elementIds", apiVersion)
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
            AddNullableQuery("roomToleranceZ", parameter.RoomToleranceZ);
            AddQuery("specialty", parameter.Specialty);
            AddQuery("systemType", parameter.SystemType);
        }
    }
}