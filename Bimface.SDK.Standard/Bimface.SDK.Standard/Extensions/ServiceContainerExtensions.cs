#region

using System;
using System.ComponentModel.Design;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class ServiceContainerExtensions
    {
        #region Others

        /// <summary>
        ///     Add a service to the <see cref="IServiceContainer"/>
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <param name="creator">The method to create the service instance</param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer AddService<TService>(this IServiceContainer container, Func<TService> creator)
        {
            container.RemoveService(typeof(TService));
            container.AddService(typeof(TService), (c, t) => creator());
            return container;
        }

        /// <summary>
        ///     Add a service to the <see cref="IServiceContainer"/>
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <param name="creator">The method to create the service instance from the <see cref="IServiceContainer"/></param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer AddService<TService>(this IServiceContainer            container,
                                                             Func<IServiceContainer, TService> creator)
        {
            container.AddService(typeof(TService), (c, t) => creator(c));
            return container;
        }

        /// <summary>
        ///     Add a service to the <see cref="IServiceContainer"/>
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <typeparam name="TImplementation">The type of the service implementation</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer AddService<TService, TImplementation>(this IServiceContainer container)
            where TImplementation : TService
        {
            return container.AddService<TService>(() => container.CreateInstance<TImplementation>());
        }

        public static IServiceContainer Singleton(this IServiceContainer container, Type serviceType, object implementation)
        {
            container.RemoveService(serviceType);
            container.AddService(serviceType, implementation);
            return container;
        }

        /// <summary>
        ///     Add a singleton service to the <see cref="IServiceContainer"/>
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <param name="implementation">The only instance of the service</param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer Singleton<TService>(this IServiceContainer container,
                                                            TService               implementation)
        {
            container.RemoveService(typeof(TService));
            container.AddService(typeof(TService), implementation);
            return container;
        }

        /// <summary>
        ///     Add a singleton service to the <see cref="IServiceContainer"/>
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <param name="creator">The method to create the service instance</param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer Singleton<TService>(this IServiceContainer container,
                                                            Func<TService>         creator)
        {
            container.RemoveService(typeof(TService));
            var lazy = new Lazy<TService>(creator);
            return container.AddService(() => lazy.Value);
        }

        /// <summary>
        ///     Add a singleton service to the <see cref="IServiceContainer"/>
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <param name="creator">The method to create the service instance from the <see cref="IServiceContainer"/></param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer Singleton<TService>(this IServiceContainer            container,
                                                            Func<IServiceContainer, TService> creator)
        {
            var lazy = new Lazy<TService>(() => creator(container));
            return container.AddService(() => lazy.Value);
        }

        /// <summary>
        ///     Add a singleton service to the <see cref="IServiceContainer"/>. Use this method if the <see cref="TService"/> itself is the implementation
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer Singleton<TService>(this IServiceContainer container)
        {
            return container.Singleton<TService, TService>();
        }

        /// <summary>
        ///     Add a service instance by providing the implementing type, a new singleton will be automatically created from the
        ///     <see cref="IServiceContainer" />
        /// </summary>
        /// <typeparam name="TService">The type of the service</typeparam>
        /// <typeparam name="TImplementation">The type of the service implementation</typeparam>
        /// <param name="container">The <see cref="IServiceContainer"/> instance</param>
        /// <returns>The <see cref="IServiceContainer"/> instance</returns>
        public static IServiceContainer Singleton<TService, TImplementation>(this IServiceContainer container)
            where TImplementation : TService
        {
            return container.Singleton<TService>(() => container.CreateInstance<TImplementation>());
        }

        #endregion
    }
}