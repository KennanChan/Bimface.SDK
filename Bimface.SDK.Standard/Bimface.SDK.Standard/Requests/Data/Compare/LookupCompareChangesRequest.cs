using Bimface.SDK.Entities.Parameters.Data.Compare;

namespace Bimface.SDK.Requests.Data.Compare
{
    internal class LookupCompareChangesRequest : BimfaceCompareDataApiRequest
    {
        public LookupCompareChangesRequest(LookupCompareChangesParameter parameter, string apiVersion = DefaultApiVersion)
            : base(parameter, "/elementChange", apiVersion)
        {
            AddQuery("followingElementId", parameter.FollowingElementId);
            AddNullableQuery("followingFileId", parameter.FollowingFileId);
            AddQuery("previousElementId", parameter.PreviousElementId);
            AddNullableQuery("previousFileId", parameter.PreviousFileId);
        }
    }
}