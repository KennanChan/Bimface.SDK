#region

using System;
using System.Collections.Concurrent;
using System.ComponentModel.Design;
using System.Linq;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using Bimface.SDK.Services;

#endregion

namespace Bimface.SDK
{
    public class BimfaceClient : IServiceContainer
    {
        #region Fields

        private bool _initialized;

        #endregion

        #region Constructors

        private BimfaceClient(AppCredential credential, IServiceContainer container)
        {
            Container = container ?? new ServiceContainer();
            Container.Singleton(credential);
            Initialize();
        }

        #endregion

        #region Properties

        private static ConcurrentDictionary<AppCredential, BimfaceClient> Clients { get; } =
            new ConcurrentDictionary<AppCredential, BimfaceClient>();

        private IServiceContainer Container { get; }

        #endregion

        #region Interface Implementations

        public void AddService(Type serviceType, ServiceCreatorCallback callback)
        {
            Container.AddService(serviceType, callback);
        }

        public void AddService(Type serviceType, ServiceCreatorCallback callback, bool promote)
        {
            Container.AddService(serviceType, callback, promote);
        }

        public void AddService(Type serviceType, object serviceInstance)
        {
            Container.AddService(serviceType, serviceInstance);
        }

        public void AddService(Type serviceType, object serviceInstance, bool promote)
        {
            Container.AddService(serviceType, serviceInstance, promote);
        }

        public void RemoveService(Type serviceType)
        {
            Container.RemoveService(serviceType);
        }

        public void RemoveService(Type serviceType, bool promote)
        {
            Container.RemoveService(serviceType, promote);
        }

        public object GetService(Type serviceType)
        {
            return Container.GetService(serviceType);
        }

        #endregion

        #region Others

        /// <summary>
        ///     Get or create a <see cref="BimfaceClient" /> using the <see cref="AppCredential" /> acquired from bimface.com
        /// </summary>
        /// <param name="credential">The app key and appsecret pair</param>
        /// <param name="container">The <see cref="IServiceContainer" /> used by the user's system</param>
        /// <returns>The client</returns>
        public static BimfaceClient GetOrCreate(AppCredential credential, IServiceContainer container = null)
        {
            return Clients.GetOrAdd(credential, c => new BimfaceClient(c, container));
        }

        /// <summary>
        ///     Initialize all the internal services
        /// </summary>
        private void Initialize()
        {
            if (_initialized) return;
            Container
               .AddService<ILogService, DefaultLogger>()
               .AddService<IHttpClient, DefaultHttpClient>()
               .AddService<IJsonSerializer, NewtonsoftJsonSerializer>()
               .AddService<IResponseResolver, DefaultResponseResolver>()
               .Singleton<IHttpContext, HttpContext>()
               .Singleton<INamingRule, CamelCaseNamingRule>()
               .Singleton<IAuthorizationService, AuthorizationService>()
               .Singleton<IFileService, FileService>()
               .Singleton<IFileDataService, FileDataService>()
               .Singleton<IIntegrateService, IntegrateService>()
               .Singleton<IIntegrateDataService, IntegrateDataService>()
               .Singleton<ICompareService, CompareService>()
               .Singleton<ICompareDataService, CompareDataService>()
               .Singleton<IShareService, ShareService>()
               .Singleton<ITranslateService, TranslateService>()
               .Singleton<IViewTokenService, ViewTokenService>()
               .Singleton<IRfaFileService, RfaFileService>()
               .Singleton<IOfflineDatabagService, OfflineDatabagService>()
               .Singleton<IDSLDataService, DSLDataService>()
               .Singleton<IDatabagDataService, DatabagDataService>()
               .Singleton(this);
            AppDomain.CurrentDomain.GetAssemblies()
                     .SelectMany(assembly => assembly.GetConcreteTypes<IServiceInitializer>())
                     .ToList()
                     .ForEach(
                          initializerType =>
                          {
                              var initializer = Container.GetService(initializerType) as IServiceInitializer ??
                                                Container.CreateInstance(initializerType) as IServiceInitializer;
                              if (null == initializer || initializer.HasInitialized) return;
                              Container.Singleton(initializerType, initializer);
                              initializer.Initialize(Container);
                          });
            _initialized = true;
        }

        #endregion
    }
}