using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.Compare;

namespace Bimface.SDK.Interfaces.Core
{
    public interface ICompareDataService
    {
        Task<ModelCompareChange> LookupCompareChange(LookupCompareChangesParameter parameter);
        Task<Tree> LookupCompareCategoryTree(LookupCompareCategoryTreeParameter parameter);
        Task<Pagination<ModelCompareDiff>> ListCompareDiff(ListCompareDiffParameter parameter);
    }
}