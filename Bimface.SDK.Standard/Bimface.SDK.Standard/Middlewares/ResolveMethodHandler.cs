using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Infrastructure;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bimface.SDK.Middlewares
{
    internal class ResolveMethodHandler : LogObject, IMiddleware
    {
        private ConcurrentDictionary<Type, string> Methods { get; } = new ConcurrentDictionary<Type, string>();

        public Task<bool> Handle(HttpRequest request)
        {
            try
            {
                var method = Methods.GetOrAdd(request.GetType(),
                    type => type.GetCustomAttributes<HttpMethodAttribute>(true).FirstOrDefault()?.Method);
                if (!string.IsNullOrWhiteSpace(method))
                {
                    request.SetMethod(method);
                }

                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                Error(e);
                return Task.FromResult(false);
            }
        }
    }
}
