#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.OfflineDatabag;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class OfflineDatabagService : HttpService, IOfflineDatabagService
    {
        #region Interface Implementations

        public Task<DatabagDerivativeEntity> CreateCompareOfflineDatabag(CreateCompareOfflineDatabagParameter parameter)
        {
            return FetchAsync<DatabagDerivativeEntity, CreateCompareOfflineDatabagParameter>(parameter);
        }

        public Task<DatabagDerivativeEntity> CreateFileOfflineDatabag(CreateFileOfflineDatabagParameter parameter)
        {
            return FetchAsync<DatabagDerivativeEntity, CreateFileOfflineDatabagParameter>(parameter);
        }

        public Task<DatabagDerivativeEntity> CreateIntegrateOfflineDatabag(CreateIntegrateOfflineDatabagParameter parameter)
        {
            return FetchAsync<DatabagDerivativeEntity, CreateIntegrateOfflineDatabagParameter>(parameter);
        }

        public Task<DatabagDerivativeEntity> LookupCompareOfflineDatabag(LookupCompareOfflineDatabagParameter parameter)
        {
            return FetchAsync<DatabagDerivativeEntity, LookupCompareOfflineDatabagParameter>(parameter);
        }

        public Task<string> LookupCompareOfflineDatabagDownloadUrl(LookupCompareOfflineDatabagDownloadUrlParameter parameter)
        {
            return FetchAsync<string, LookupCompareOfflineDatabagDownloadUrlParameter>(parameter);
        }

        public Task<DatabagDerivativeEntity> LookupFileOfflineDatabag(LookupFileOfflineDatabagParameter parameter)
        {
            return FetchAsync<DatabagDerivativeEntity, LookupFileOfflineDatabagParameter>(parameter);
        }

        public Task<string> LookupFileOfflineDatabagDownloadUrl(LookupFileOfflineDatabagDownloadUrlParameter parameter)
        {
            return FetchAsync<string, LookupFileOfflineDatabagDownloadUrlParameter>(parameter);
        }

        public Task<DatabagDerivativeEntity> LookupIntegrateOfflineDatabag(LookupIntegrateOfflineDatabagParameter parameter)
        {
            return FetchAsync<DatabagDerivativeEntity, LookupIntegrateOfflineDatabagParameter>(parameter);
        }

        public Task<string> LookupIntegrateOfflineDatabagDownloadUrl(LookupIntegrateOfflineDatabagDownloadUrlParameter parameter)
        {
            return FetchAsync<string, LookupIntegrateOfflineDatabagDownloadUrlParameter>(parameter);
        }

        #endregion
    }
}