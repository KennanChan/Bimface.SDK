using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace Bimface.SDK.Entities.Http
{
    public class HttpContext : IHttpContext
    {
        private ConcurrentDictionary<Type, IRequestPlugin> Middlewares { get; } =
            new ConcurrentDictionary<Type, IRequestPlugin>();

        public void UseRequestPlugin(IRequestPlugin requestPlugin)
        {
            Middlewares.AddOrUpdate(requestPlugin.GetType(), requestPlugin, (t, m) => requestPlugin);
        }

        public IEnumerable<IRequestPlugin> GetRequestPlugins()
        {
            return Middlewares.Values.ToList();
        }
    }
}