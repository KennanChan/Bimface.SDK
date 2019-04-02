#region

using System;
using System.Threading.Tasks;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Requests.Common;
using Bimface.SDK.Utilities;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     The default implementation of <see cref="IAuthorizationService" /> to manage access token for other business
    ///     service
    /// </summary>
    internal class AuthorizationService : HttpService, IAuthorizationService
    {
        #region Properties

        /// <summary>
        ///     In-memory cache from access token
        /// </summary>
        private AccessTokenEntity AccessToken { get; set; }

        /// <summary>
        ///     The tolerance to refresh the token
        /// </summary>
        private TimeSpan ExpireTolerance { get; } = TimeSpan.FromSeconds(1);

        private AsyncLocker Locker { get; } = new AsyncLocker();

        #endregion

        #region Interface Implementations

        public async Task<string> GetAccessToken()
        {
            using (Locker.LockAsync())
            {
                try
                {
                    //Refresh the access token if there is not cache or the token is about to expire
                    if (AccessToken == null || AccessToken.ExpireTime - DateTime.Now < ExpireTolerance)
                        AccessToken = await FetchAsync<AccessTokenEntity>(new OAuthRequest(Container.GetService<AppCredential>()));

                    return AccessToken.Token;
                }
                catch (Exception e)
                {
                    Error(e);
                    return null;
                }
            }
        }

        #endregion
    }
}