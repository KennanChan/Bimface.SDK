#region

using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Services;

#endregion

namespace Bimface.SDK.Plugins
{
    /// <summary>
    ///     Use this plugin to automatically add Authorization header to an <see cref="HttpRequest" /> attributed with
    ///     <see cref="BimfaceAuthAttribute" />
    /// </summary>
    internal class BimfaceAuthPlugin : AppDomainServiceInitializer, IRequestPlugin
    {
        #region Constructors

        internal BimfaceAuthPlugin(IAuthorizationService authorizationService)
        {
            AuthorizationService = authorizationService;
        }

        #endregion

        #region Properties

        private IAuthorizationService            AuthorizationService { get; }
        private ConcurrentDictionary<Type, bool> AuthTypes            { get; } = new ConcurrentDictionary<Type, bool>();
        private Type                             BaseParameterType    { get; } = typeof(HttpParameter);

        #endregion

        #region Interface Implementations

        /// <summary>
        ///     Add Authorization header to the <see cref="HttpRequest" />
        /// </summary>
        /// <param name="parameter">The parameter for the request</param>
        /// <param name="request">The http request</param>
        public async Task Handle(HttpParameter parameter, HttpRequest request)
        {
            try
            {
                var requireAuth = AuthTypes.GetOrAdd(parameter.GetType(), HandleType);
                if (requireAuth)
                {
                    var accessToken = await AuthorizationService.GetAccessToken();
                    request.AddHeader("Authorization", $"Bearer {accessToken}");
                }
            }
            catch (Exception e)
            {
                Error(e);
            }
        }

        public void PreBuild()
        {
            Initialize(Container);
        }

        #endregion

        #region Others

        protected override void Handle(Assembly assembly)
        {
            assembly.GetTypes()
                    .Where(type => !type.IsInterface)
                    .Where(type => !type.IsAbstract)
                    .Where(type => BaseParameterType.IsAssignableFrom(type))
                    .ToList()
                    .ForEach(type =>
                     {
                         var result = HandleType(type);
                         AuthTypes.AddOrUpdate(type, result, (t, b) => result);
                     });
        }

        private bool HandleType(Type type)
        {
            return type.GetCustomAttributes<BimfaceAuthAttribute>(true).All(attribute => attribute.Enabled);
        }

        #endregion
    }
}