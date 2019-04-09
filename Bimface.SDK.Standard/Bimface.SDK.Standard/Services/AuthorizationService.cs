#region

using System;
using System.Threading.Tasks;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Core.Responses;
using Bimface.SDK.Entities.Parameters.Common;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
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
            using (await Locker.LockAsync())
            {
                try
                {
                    if (AccessToken == null || AccessToken.ExpireTime - DateTime.Now < ExpireTolerance)
                    {
                        //Refresh the access token if there is not cache or the token is about to expire
                        AccessToken = await FetchAsync<AccessTokenEntity, OAuthParameter>(new OAuthParameter(Container.GetService<AppCredential>()));
                    }

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