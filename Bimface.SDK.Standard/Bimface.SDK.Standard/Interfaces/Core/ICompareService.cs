using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Compare;

namespace Bimface.SDK.Interfaces.Core
{
    public interface ICompareService
    {
        Task<ModelCompareEntity> CreateCompare(CreateCompareParameter parameter);
        Task<ModelCompareEntity> LookupCompare(LookupCompareParameter parameter);
        Task<string> DeleteCompare(DeleteCompareParameter parameter);
    }
}