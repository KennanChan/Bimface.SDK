#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Compare;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface ICompareService
    {
        #region Others

        Task<ModelCompareEntity> CreateCompare(CreateCompareParameter parameter);
        Task<string> DeleteCompare(DeleteCompareParameter             parameter);
        Task<ModelCompareEntity> LookupCompare(LookupCompareParameter parameter);

        #endregion
    }
}