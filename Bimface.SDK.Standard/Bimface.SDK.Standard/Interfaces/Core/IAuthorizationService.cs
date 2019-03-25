using System.Threading.Tasks;

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IAuthorizationService
    {
        Task<string> GetAccessToken();
    }
}