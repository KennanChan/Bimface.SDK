using System.Threading.Tasks;

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IAuthorizationService
    {
        /// <summary>
        ///     Get a bimface granted access token to continue with other bimface business
        /// </summary>
        /// <returns></returns>
        Task<string> GetAccessToken();
    }
}