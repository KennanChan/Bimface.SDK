using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Entities.Parameters.Share;

namespace Bimface.SDK.Interfaces.Core
{
    public interface IShareService
    {
        Task<ShareLinkEntity> CreateShare(CreateShareParameter parameter);
        Task<ShareLinkEntity[]> GetShares(ListSharesParameter  parameter);
        Task<string> DeleteShare(DeleteShareParameter          parameter);
        Task<ShareLinkEntity> GetShare(LookupShareParameter    parameter);
    }
}