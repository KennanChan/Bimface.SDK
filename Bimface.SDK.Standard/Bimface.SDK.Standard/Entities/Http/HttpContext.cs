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
        private ConcurrentDictionary<Type, IMiddleware> Middlewares { get; } =
            new ConcurrentDictionary<Type, IMiddleware>();

        public void UseMiddleware(IMiddleware middleware)
        {
            Middlewares.AddOrUpdate(middleware.GetType(), middleware, (t, m) => middleware);
        }

        public IEnumerable<IMiddleware> GetMiddlewares()
        {
            return Middlewares.Values.ToList();
        }
    }
}