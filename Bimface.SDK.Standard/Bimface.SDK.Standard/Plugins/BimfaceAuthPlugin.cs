using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;

namespace Bimface.SDK.Plugins
{
    internal class BimfaceAuthPlugin : LogObject, IRequestPlugin
    {
        #region Constructors

        internal BimfaceAuthPlugin(IAuthorizationService authorizationService)
        {
            AuthorizationService = authorizationService;
        }

        #endregion

        #region Properties

        private IAuthorizationService AuthorizationService { get; }

        private ConcurrentDictionary<Type, bool> AuthTypes { get; } = new ConcurrentDictionary<Type, bool>();

        #endregion

        #region Interface Implementations

        public async Task<bool> Handle(HttpRequest request)
        {
            try
            {
                var requireAuth = AuthTypes.GetOrAdd(request.GetType(),
                    type => type.GetCustomAttributes<BimfaceAuthAttribute>(true).Any());
                if (requireAuth)
                {
                    var accessToken = await AuthorizationService.GetAccessToken();
                    request.AddHeader("Authorization", $"Bear {accessToken}");
                    return true;
                }

                return true;
            }
            catch (Exception e)
            {
                Error(e);
                return false;
            }
        }

        #endregion
    }
}