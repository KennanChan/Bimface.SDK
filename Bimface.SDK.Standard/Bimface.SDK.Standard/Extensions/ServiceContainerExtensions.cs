#region

using System;
using System.ComponentModel.Design;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class ServiceContainerExtensions
    {
        #region Others

        public static IServiceContainer AddService<TService>(this IServiceContainer container, Func<TService> creator)
        {
            container.AddService(typeof(TService), (c, t) => creator());
            return container;
        }

        public static IServiceContainer AddService<TService>(this IServiceContainer            container,
                                                             Func<IServiceContainer, TService> creator)
        {
            container.AddService(typeof(TService), (c, t) => creator(c));
            return container;
        }

        public static IServiceContainer AddService<TService, TImplementation>(this IServiceContainer container)
            where TImplementation : TService
        {
            return container.AddService<TService>(() =>
            {
                var implType = typeof(TImplementation);
                return container.CreateInstance<TImplementation>();
            });
        }

        public static IServiceContainer Singleton<TService>(this IServiceContainer container,
                                                            TService               implementation)
        {
            container.RemoveService(typeof(TService));
            container.AddService(typeof(TService), implementation);
            return container;
        }

        public static IServiceContainer Singleton<TService>(this IServiceContainer container,
                                                            Func<TService>         creator)
        {
            container.RemoveService(typeof(TService));
            var lazy = new Lazy<TService>(creator);
            return container.AddService(() => lazy.Value);
        }

        public static IServiceContainer Singleton<TService>(this IServiceContainer            container,
                                                            Func<IServiceContainer, TService> creator)
        {
            var lazy = new Lazy<TService>(() => creator(container));
            return container.AddService(() => lazy.Value);
        }

        public static IServiceContainer Singleton<TService>(this IServiceContainer container)
        {
            return container.Singleton<TService, TService>();
        }

        /// <summary>
        ///     Add a service instance by providing the implementing type, a new singleton will be automatically created from the
        ///     <see cref="IServiceContainer" />
        /// </summary>
        /// <typeparam name="TService">Service to add to the </typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        /// <param name="container"></param>
        /// <returns></returns>
        public static IServiceContainer Singleton<TService, TImplementation>(this IServiceContainer container)
            where TImplementation : TService
        {
            return container.Singleton<TService>(() =>
            {
                var implType = typeof(TImplementation);
                return container.CreateInstance<TImplementation>();
            });
        }

        #endregion
    }
}