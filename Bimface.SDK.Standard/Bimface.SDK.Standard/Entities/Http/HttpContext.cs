#region

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Entities.Http
{
    public class HttpContext : IHttpContext
    {
        #region Properties

        private ConcurrentDictionary<Type, IRequestPlugin> Middlewares { get; } =
            new ConcurrentDictionary<Type, IRequestPlugin>();

        #endregion

        #region Interface Implementations

        public IEnumerable<IRequestPlugin> GetRequestPlugins()
        {
            return Middlewares.Values.ToList();
        }

        public void UseRequestPlugin(IRequestPlugin requestPlugin)
        {
            Middlewares.AddOrUpdate(requestPlugin.GetType(), requestPlugin, (t, m) => requestPlugin);
        }

        #endregion
    }
}