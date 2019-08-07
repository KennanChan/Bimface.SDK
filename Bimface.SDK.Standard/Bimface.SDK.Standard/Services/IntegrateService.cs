#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Integrate;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class IntegrateService : HttpService, IIntegrateService
    {
        #region Interface Implementations

        public Task<FileIntegrateEntity> CreateIntegrate(CreateIntegrateParameter parameter)
        {
            return FetchAsync<FileIntegrateEntity, CreateIntegrateParameter>(parameter);
        }

        public Task DeleteIntegrate(DeleteIntegrateParameter parameter)
        {
            return SendAsync(parameter);
        }

        public Task<PagedList<FileIntegrateDetailEntity>> ListFileIntegrateDetails(ListFileIntegrateDetailsParameter parameter)
        {
            return FetchAsync<PagedList<FileIntegrateDetailEntity>, ListFileIntegrateDetailsParameter>(parameter);
        }

        public Task<FileIntegrateEntity> LookupIntegrate(LookupIntegrateParameter parameter)
        {
            return FetchAsync<FileIntegrateEntity, LookupIntegrateParameter>(parameter);
        }

        #endregion
    }
}