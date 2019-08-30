#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Data.Compare;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ICompareDataService
    {
        #region Others

        Task<Pagination<ModelCompareDiff>> ListCompareDiff(ListCompareDiffParameter parameter);
        Task<Tree> LookupCompareCategoryTree(LookupCompareCategoryTreeParameter     parameter);
        Task<ModelCompareChange> LookupCompareChange(LookupCompareChangesParameter  parameter);

        #endregion
    }
}