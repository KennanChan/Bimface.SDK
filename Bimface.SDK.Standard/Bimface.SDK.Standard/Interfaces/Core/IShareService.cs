#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Share;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IShareService
    {
        #region Others

        Task<ShareLinkEntity> CreateShare(CreateFileShareParameter      parameter);
        Task<ShareLinkEntity> CreateShare(CreateIntegrateShareParameter parameter);
        Task<string> DeleteShare(DeleteFileShareParameter               parameter);
        Task<string> DeleteShare(DeleteIntegrateShareParameter          parameter);
        Task<ShareLinkEntity> GetShare(LookupFileShareParameter         parameter);
        Task<ShareLinkEntity> GetShare(LookupIntegrateShareParameter    parameter);
        Task<ShareLinkEntity[]> ListShares(ListSharesParameter          parameter);

        #endregion
    }
}