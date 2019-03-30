using System;
using System.Threading;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Core;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using Bimface.SDK.Requests.Common;

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     The default implementation of <see cref="IAuthorizationService"/> to manage access token for other business service
    /// </summary>
    internal class AuthorizationService : HttpService, IAuthorizationService
    {
        #region Fields

        private SemaphoreSlim Semaphore { get; } = new SemaphoreSlim(1, 1);

        #endregion

        #region Constructors

        public AuthorizationService(IHttpClient client, IResponseResolver responseResolver)
            : base(client, responseResolver)
        {
        }

        #endregion

        #region Properties

        /// <summary>
        ///     In-memory cache from access token
        /// </summary>
        private AccessTokenEntity AccessToken { get; set; }

        /// <summary>
        ///     The tolerance to refresh the token
        /// </summary>
        private TimeSpan ExpireTolerance { get; } = TimeSpan.FromSeconds(1);

        #endregion

        #region Interface Implementations

        public async Task<string> GetAccessToken()
        {
            await Semaphore.WaitAsync();
            try
            {

                //Refresh the access token if there is not cache or the token is about to expire
                if (AccessToken == null || AccessToken.ExpireTime - DateTime.Now < ExpireTolerance)
                    AccessToken = await FetchAsync<AccessTokenEntity>(Container.GetService<OAuthRequest>());

                return AccessToken.Token;
            }
            catch (Exception e)
            {
                Error(e);
                return null;
            }
            finally
            {
                Semaphore.Release();
            }
        }

        #endregion
    }
}