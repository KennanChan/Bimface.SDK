using System;
using System.ComponentModel.Design;

namespace Bimface.SDK.Extensions
{
    public static class ServiceContainerExtensions
    {
        public static IServiceContainer AddService<TService>(this IServiceContainer container, Func<TService> creator)
        {
            container.AddService(typeof(TService), (c, t) => creator());
            return container;
        }

        public static IServiceContainer AddService<TService>(this IServiceContainer container,
            Func<IServiceContainer, TService> creator)
        {
            container.AddService(typeof(TService), (c, t) => creator(c));
            return container;
        }

        public static IServiceContainer AddService<TService, TImplementation>(this IServiceContainer container)
            where TImplementation : TService
        {
            return container.AddService(() =>
            {
                var implType = typeof(TImplementation);
                return typeof(TService) == implType
                    ? container.CreateInstance<TImplementation>()
                    : container.GetService<TImplementation>();
            });
        }

        public static IServiceContainer Singleton<TService>(this IServiceContainer container,
            TService implementation)
        {
            container.AddService(typeof(TService), implementation);
            return container;
        }

        public static IServiceContainer Singleton<TService>(this IServiceContainer container,
            Func<TService> creator)
        {
            var lazy = new Lazy<TService>(creator);
            return container.AddService(() => lazy.Value);
        }

        public static IServiceContainer Singleton<TService>(this IServiceContainer container,
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
        ///     Add a service instance by providing the implementing type, a new singleton will be automatically created from the <see cref="IServiceContainer"/> 
        /// </summary>
        /// <typeparam name="TService">Service to add to the </typeparam>
        /// <typeparam name="TImplementation"></typeparam>
        /// <param name="container"></param>
        /// <returns></returns>
        public static IServiceContainer Singleton<TService, TImplementation>(this IServiceContainer container)
            where TImplementation : TService
        {
            return container.Singleton(() =>
            {
                var implType = typeof(TImplementation);
                return typeof(TService) == implType
                    ? container.CreateInstance<TImplementation>()
                    : container.GetService<TImplementation>();
            });
        }
    }
}