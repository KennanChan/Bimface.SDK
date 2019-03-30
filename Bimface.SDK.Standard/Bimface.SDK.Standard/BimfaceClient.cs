#region

using System;
using System.ComponentModel.Design;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Http;
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
        #region Constructors

        private BimfaceClient(AppCredential credential, IServiceContainer container)
        {
            Container = container ?? new ServiceContainer();
            Container.Singleton(credential);
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

        /// <summary>
        ///     Get or create a <see cref="BimfaceClient" /> using the <see cref="AppCredential" /> acquired from bimface.com
        /// </summary>
        /// <param name="credential"></param>
        /// <param name="container"></param>
        /// <returns></returns>
        public static BimfaceClient GetOrCreate(AppCredential credential, IServiceContainer container = null)
        {
            return container?.GetService<BimfaceClient>() ?? new BimfaceClient(credential, container);
        }

        public void Init()
        {
            Container
               .AddService<ILog, DefaultLogger>()
               .AddService<IHttpClient, DefaultHttpClient>()
               .AddService<IJsonSerializer, DefaultJsonSerializer>()
               .AddService<IResponseResolver, DefaultResponseResolver>()
               .Singleton<IFileService, FileService>()
               .Singleton<BimfaceAuthPlugin>()
               .Singleton<ResolveHeadersPlugin>()
               .Singleton<IHttpContext, HttpContext>()
               .Singleton(this);
            Container
               .GetService<IHttpContext>()
               .UseContainer(Container)
               .UseRequestPlugin<BimfaceAuthPlugin>()
               .UseRequestPlugin<ResolveHeadersPlugin>();
        }
    }
}