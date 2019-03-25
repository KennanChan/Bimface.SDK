using System.ComponentModel.Design;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

namespace Bimface.SDK.Extensions
{
    internal static class HttpContextExtensions
    {
        #region Properties

        private static IServiceContainer Container { get; set; }

        #endregion

        internal static IHttpContext UseContainer(this IHttpContext context, IServiceContainer container)
        {
            Container = container;
            return context;
        }

        internal static IHttpContext UseRequestPlugin<TMiddleware>(this IHttpContext context,
            IServiceContainer container = null)
            where TMiddleware : IRequestPlugin
        {
            container = container ?? Container;
            if (null != container)
                context.UseRequestPlugin(container.GetService<TMiddleware>());
            return context;
        }
    }
}