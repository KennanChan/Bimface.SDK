#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.OfflineDatabag;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IOfflineDatabagService
    {
        #region Others

        Task<DatabagDerivativeEntity> CreateCompareOfflineDatabag(CreateCompareOfflineDatabagParameter          parameter);
        Task<DatabagDerivativeEntity> CreateFileOfflineDatabag(CreateFileOfflineDatabagParameter                parameter);
        Task<DatabagDerivativeEntity> CreateIntegrateOfflineDatabag(CreateIntegrateOfflineDatabagParameter      parameter);
        Task<DatabagDerivativeEntity> LookupCompareOfflineDatabag(LookupCompareOfflineDatabagParameter          parameter);
        Task<string> LookupCompareOfflineDatabagDownloadUrl(LookupCompareOfflineDatabagDownloadUrlParameter     parameter);
        Task<DatabagDerivativeEntity> LookupFileOfflineDatabag(LookupFileOfflineDatabagParameter                parameter);
        Task<string> LookupFileOfflineDatabagDownloadUrl(LookupFileOfflineDatabagDownloadUrlParameter           parameter);
        Task<DatabagDerivativeEntity> LookupIntegrateOfflineDatabag(LookupIntegrateOfflineDatabagParameter      parameter);
        Task<string> LookupIntegrateOfflineDatabagDownloadUrl(LookupIntegrateOfflineDatabagDownloadUrlParameter parameter);

        #endregion
    }
}