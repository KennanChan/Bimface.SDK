#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Share;
using Bimface.SDK.Interfaces.Core;

#endregion

namespace Bimface.SDK.Services
{
    internal class ShareService : HttpService, IShareService
    {
        #region Interface Implementations

        public Task<ShareLinkEntity> CreateShare(CreateShareParameter parameter)
        {
            return FetchAsync<ShareLinkEntity, CreateShareParameter>(parameter);
        }

        public Task<string> DeleteShare(DeleteShareParameter parameter)
        {
            return FetchAsync<string, DeleteShareParameter>(parameter);
        }

        public Task<ShareLinkEntity> GetShare(LookupShareParameter parameter)
        {
            return FetchAsync<ShareLinkEntity, LookupShareParameter>(parameter);
        }

        public Task<ShareLinkEntity[]> GetShares(ListSharesParameter parameter)
        {
            return FetchAsync<ShareLinkEntity[], ListSharesParameter>(parameter);
        }

        #endregion
    }
}