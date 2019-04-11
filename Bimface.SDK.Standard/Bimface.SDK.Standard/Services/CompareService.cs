#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Compare;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class CompareService : HttpService, ICompareService
    {
        #region Interface Implementations

        public Task<ModelCompareEntity> CreateCompare(CreateCompareParameter parameter)
        {
            return FetchAsync<ModelCompareEntity, CreateCompareParameter>(parameter);
        }

        public Task<string> DeleteCompare(DeleteCompareParameter parameter)
        {
            return FetchAsync<string, DeleteCompareParameter>(parameter);
        }

        public Task<ModelCompareEntity> LookupCompare(LookupCompareParameter parameter)
        {
            return FetchAsync<ModelCompareEntity, LookupCompareParameter>(parameter);
        }

        #endregion
    }
}