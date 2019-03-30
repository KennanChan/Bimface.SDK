#region

using System.Threading.Tasks;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IAuthorizationService
    {
        #region Others

        /// <summary>
        ///     Get a bimface granted access token to continue with other bimface business
        /// </summary>
        /// <returns></returns>
        Task<string> GetAccessToken();

        #endregion
    }
}