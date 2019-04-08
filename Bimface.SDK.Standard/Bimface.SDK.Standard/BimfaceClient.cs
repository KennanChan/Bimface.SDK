#region

using System;
using System.ComponentModel.Design;
using System.Linq;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using Bimface.SDK.Plugins;
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
        /// <param name="credential"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        public static BimfaceClient Create(AppCredential credential, IServiceContainer container = null)
        {
            return container?.GetService<BimfaceClient>() ?? new BimfaceClient(credential, container);
        }

        private void Initialize()
        {
            if (_initialized) return;
            Container
               .AddService<ILog, DefaultLogger>()
               .AddService<IHttpClient, DefaultHttpClient>()
               .AddService<IJsonSerializer, DefaultJsonSerializer>()
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
               .Singleton<IViewService, ViewService>()
               .Singleton<IRfaFileService, RfaFileService>()
               .Singleton<IOfflineDatabagService, OfflineDatabagService>()
               .Singleton<IDSLDataService, DSLDataService>()
               .Singleton<IDatabagDataService, DatabagDataService>()
               .Singleton<BimfaceAuthPlugin>()
               .Singleton<ResolveHeadersPlugin>()
               .Singleton(this);
            Container
               .GetService<IHttpContext>()
               .UseContainer(Container)
               .UseRequestPlugin<BimfaceAuthPlugin>()
               .UseRequestPlugin<ResolveHeadersPlugin>();
            InitializeRequestBuilders();
            _initialized = true;
        }

        private void InitializeRequestBuilders()
        {
            var baseType             = typeof(HttpParameter);
            var genericInterfaceType = typeof(IRequestBuilder<>);
            var genericType          = typeof(RequestBuilder<>);
            AppDomain.CurrentDomain.GetAssemblies()
                     .SelectMany(assembly => assembly.GetTypes())
                     .Where(type => !type.IsAbstract)
                     .Where(type => !type.IsInterface)
                     .Where(type => baseType.IsAssignableFrom(type))
                     .ToList()
                     .ForEach(type =>
                      {
                          var typeArgs             = new[] {type};
                          var builderInterfaceType = genericInterfaceType.MakeGenericType(typeArgs);
                          var builderType          = genericType.MakeGenericType(typeArgs);
                          var builder              = Container.CreateInstance(builderType) as IRequestBuilder;
                          builder?.Init();
                          Container.AddService(builderInterfaceType, builder);
                      });
        }

        #endregion
    }
}