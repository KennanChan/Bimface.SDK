#region

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

#endregion

namespace Bimface.SDK.Plugins
{
    /// <summary>
    ///     Use this plugin to automatically add Authorization header to an <see cref="HttpRequest"/> attributed with <see cref="BimfaceAuthAttribute"/> 
    /// </summary>
    internal class BimfaceAuthPlugin : LogObject, IRequestPlugin
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
        private Type                             BaseRequestType      { get; } = typeof(HttpRequest);

        #endregion

        #region Interface Implementations

        /// <summary>
        ///     Add Authorization header to the <see cref="HttpRequest" />
        /// </summary>
        /// <param name="request">The http request</param>
        /// <returns>The result of the plugin</returns>
        public async Task<bool> Handle(HttpRequest request)
        {
            try
            {
                var requireAuth = AuthTypes.GetOrAdd(request.GetType(), HandleType);
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

        public void Prebuild()
        {
            AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(AnalyzeAssembly);
            AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
        }

        private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            AnalyzeAssembly(args.LoadedAssembly);
        }

        private void AnalyzeAssembly(Assembly assembly)
        {
            assembly.GetTypes()
                    .Where(type => !type.IsInterface)
                    .Where(type => !type.IsAbstract)
                    .Where(type => BaseRequestType.IsAssignableFrom(type))
                    .ToList()
                    .ForEach(type =>
                     {
                         var result = HandleType(type);
                         AuthTypes.AddOrUpdate(type, result, (t, b) => result);
                     });
        }

        private bool HandleType(Type type)
        {
            return type.GetCustomAttributes<BimfaceAuthAttribute>(true).Any();
        }

        #endregion

        public void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyLoad -= CurrentDomain_AssemblyLoad;
            AuthTypes.Clear();
        }
    }
}