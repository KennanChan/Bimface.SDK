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

        private ConcurrentDictionary<Type, IRequestPlugin> Plugins { get; } =
            new ConcurrentDictionary<Type, IRequestPlugin>();

        #endregion

        #region Interface Implementations

        public IEnumerable<IRequestPlugin> GetRequestPlugins()
        {
            return Plugins.Values.ToList();
        }

        public void UseRequestPlugin(IRequestPlugin requestPlugin)
        {
            Plugins.AddOrUpdate(requestPlugin.GetType(), requestPlugin, (t, m) => requestPlugin);
        }

        #endregion
    }
}