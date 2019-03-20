﻿using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using System.ComponentModel.Design;

namespace Bimface.SDK.Extensions
{
    internal static class HttpContextExtensions
    {
        private static IServiceContainer Container { get; set; }

        internal static IHttpContext UseMiddleware<TMiddleware>(this IHttpContext context,
            IServiceContainer container = null)
            where TMiddleware : IMiddleware
        {
            container = container ?? Container;
            if (null != container)
                context.UseMiddleware(container.GetService<TMiddleware>());
            return context;
        }

        internal static IHttpContext UseContainer(this IHttpContext context, IServiceContainer container)
        {
            Container = container;
            return context;
        }
    }
}