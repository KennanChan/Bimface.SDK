#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class ShareService : HttpService, IShareService
    {
        #region Interface Implementations

        public Task<ShareLinkEntity> CreateShare(CreateFileShareParameter parameter)
        {
            return FetchAsync<ShareLinkEntity, CreateFileShareParameter>(parameter);
        }

        public Task<ShareLinkEntity> CreateShare(CreateIntegrateShareParameter parameter)
        {
            return FetchAsync<ShareLinkEntity, CreateIntegrateShareParameter>(parameter);
        }

        public Task<string> DeleteShare(DeleteFileShareParameter parameter)
        {
            return FetchAsync<string, DeleteFileShareParameter>(parameter);
        }

        public Task<string> DeleteShare(DeleteIntegrateShareParameter parameter)
        {
            return FetchAsync<string, DeleteIntegrateShareParameter>(parameter);
        }

        public Task<ShareLinkEntity> GetShare(LookupFileShareParameter parameter)
        {
            return FetchAsync<ShareLinkEntity, LookupFileShareParameter>(parameter);
        }

        public Task<ShareLinkEntity> GetShare(LookupIntegrateShareParameter parameter)
        {
            return FetchAsync<ShareLinkEntity, LookupIntegrateShareParameter>(parameter);
        }

        public Task<ShareLinkEntity[]> ListShares(ListSharesParameter parameter)
        {
            return FetchAsync<ShareLinkEntity[], ListSharesParameter>(parameter);
        }

        #endregion
    }
}