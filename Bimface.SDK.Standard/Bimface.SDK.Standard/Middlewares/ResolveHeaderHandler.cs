using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Infrastructure;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Bimface.SDK.Middlewares
{
    internal class ResolveHeaderHandler : LogObject, IMiddleware
    {
        private ConcurrentDictionary<Type, List<KeyValuePair<string, string>>> Headers { get; } =
            new ConcurrentDictionary<Type, List<KeyValuePair<string, string>>>();

        public Task<bool> Handle(HttpRequest request)
        {
            try
            {
                var headerList = Headers.GetOrAdd(request.GetType(), type =>
                {
                    var headers = type.GetCustomAttributes<HttpHeaderAttribute>(true);
                    return headers.Select(header => new KeyValuePair<string, string>(header.Name, header.Value))
                        .ToList();
                });
                headerList.ForEach(header => request.AddHeader(header.Key, header.Value));
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