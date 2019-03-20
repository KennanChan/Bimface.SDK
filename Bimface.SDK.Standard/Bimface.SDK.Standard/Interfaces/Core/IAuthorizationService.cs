using Bimface.SDK.Entities.Core;
using System.Threading.Tasks;

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IAuthorizationService
    {
        Task<AccessTokenEntity> GetAccessToken();
        Task ClearAccessToken();
    }
}