using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.Compare;
using Bimface.SDK.Interfaces.Core;

namespace Bimface.SDK.Services
{
    internal class CompareDataService : HttpService, ICompareDataService
    {
        public Task<ModelCompareChange> LookupCompareChange(LookupCompareChangesParameter parameter)
        {
            return FetchAsync<ModelCompareChange, LookupCompareChangesParameter>(parameter);
        }

        public Task<Tree> LookupCompareCategoryTree(LookupCompareCategoryTreeParameter parameter)
        {
            return FetchAsync<Tree, LookupCompareCategoryTreeParameter>(parameter);
        }

        public Task<Pagination<ModelCompareDiff>> ListCompareDiff(ListCompareDiffParameter parameter)
        {
            return FetchAsync<Pagination<ModelCompareDiff>, ListCompareDiffParameter>(parameter);
        }
    }
}
