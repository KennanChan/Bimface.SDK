using Bimface.SDK.Entities.Core;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using Bimface.SDK.Requests;
using System;
using System.Threading.Tasks;

namespace Bimface.SDK.Services
{
    internal class AuthorizationService : HttpService, IAuthorizationService
    {
        #region Fields

        private readonly object _locker = new object();
        private AccessTokenEntity _viewToken;

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
        private AccessTokenEntity ViewToken
        {
            get
            {
                lock (_locker)
                {
                    return _viewToken;
                }
            }
            set
            {
                lock (_locker)
                {
                    _viewToken = value;
                }
            }
        }

        #endregion

        #region Interface Implementations

        public async Task<AccessTokenEntity> GetAccessToken()
        {
            try
            {
                return ViewToken ??
                       (ViewToken = await FetchAsync<AccessTokenEntity>(Container.GetService<OAuthRequest>()));
            }
            catch (Exception e)
            {
                Error(e);
                return null;
            }
        }

        public Task ClearAccessToken()
        {
            ViewToken = null;
            return Task.CompletedTask;
        }

        #endregion
    }
}