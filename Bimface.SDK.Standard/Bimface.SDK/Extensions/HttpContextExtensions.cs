﻿#region

using System.ComponentModel.Design;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Extensions
{
    internal static class HttpContextExtensions
    {
        #region Properties

        private static IServiceContainer Container { get; set; }

        #endregion

        #region Others

        internal static IHttpContext UseContainer(this IHttpContext context, IServiceContainer container)
        {
            Container = container;
            return context;
        }

        internal static IHttpContext UseRequestPlugin<TPlugin>(this IHttpContext context,
                                                               IServiceContainer container = null)
            where TPlugin : IRequestPlugin
        {
            container = container ?? Container;
            if (null != container)
                context.UseRequestPlugin(container.GetService<TPlugin>());
            return context;
        }

        #endregion
    }
}