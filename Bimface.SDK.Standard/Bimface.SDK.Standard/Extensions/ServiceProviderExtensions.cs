using System;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace Bimface.SDK.Extensions
{
    public static class ServiceProviderExtensions
    {
        /// <summary>
        ///     Create the instance of the implementation type, inject all the constructor parameters and inject properties
        /// </summary>
        /// <param name="container">The instance of <see cref="IServiceProvider" /></param>
        /// <param name="implementationType"></param>
        /// <returns></returns>
        public static object CreateInstance(this IServiceProvider container, Type implementationType)
        {
            var ctor = implementationType
                .GetConstructors(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.CreateInstance |
                                 BindingFlags.Instance).OrderByDescending(x => x.GetParameters().Length).First();
            var parameterTypes = ctor.GetParameters().Select(p => p.ParameterType);
            var dependencies = parameterTypes.Select(container.GetService).ToArray();
            var instance = Activator.CreateInstance(implementationType,
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.CreateInstance |
                BindingFlags.Instance, null, dependencies, CultureInfo.CurrentCulture);
            container.InjectProperties(instance);
            return instance;
        }

        public static T CreateInstance<T>(this IServiceProvider container)
        {
            return (T) container.CreateInstance(typeof(T));
        }

        public static T GetService<T>(this IServiceProvider container)
        {
            return (T) container.GetService(typeof(T));
        }

        internal static void InjectProperties(this IServiceProvider container, object instance)
        {
            if (null == instance) return;
            try
            {
                instance.GetInjectableProperties().ToList()
                    .ForEach(property =>
                        property.SetValue(instance, container.GetService(property.PropertyType), null));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}