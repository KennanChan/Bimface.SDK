using Bimface.SDK.Entities.Core;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using Bimface.SDK.Requests;
using System;
using System.Threading.Tasks;
using Bimface.SDK.Utilities;

namespace Bimface.SDK.Services
{
    internal class AuthorizationService : HttpService, IAuthorizationService
    {
        #region Fields

        private readonly AsyncLock _locker = new AsyncLock();

        #endregion

        #region Constructors

        public AuthorizationService(IHttpClient client, IResponseResolver responseResolver)
            : base(client, responseResolver)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        ///     In-memory cache from view token
        /// </summary>
        private AccessTokenEntity AccessToken { get; set; }

        private TimeSpan ExpireTolerance { get; } = TimeSpan.FromSeconds(1);

        #endregion

        #region Interface Implementations

        public async Task<string> GetAccessToken()
        {
            try
            {
                using (var releaser = await _locker.LockAsync())
                {
                    if (AccessToken == null || DateTime.Now - AccessToken.ExpireTime > ExpireTolerance)
                    {
                        AccessToken = await FetchAsync<AccessTokenEntity>(Container.GetService<OAuthRequest>());
                    }
                }

                return AccessToken.Token;
            }
            catch (Exception e)
            {
                Error(e);
                return null;
            }
        }

        #endregion
    }
}