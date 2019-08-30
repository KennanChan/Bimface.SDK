#region

using System;
using System.Collections.Generic;
using System.Linq;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    internal class HttpClientFactory : LogObject, IHttpClient
    {
        #region Constructors

        public HttpClientFactory()
        {
            var interfaceType = typeof(IHttpClient);
            AvailableClients = new Lazy<List<IHttpClient>>(() =>
                GetType().Assembly.GetTypes()
                         .Where(type => interfaceType.IsAssignableFrom(type))
                         .Where(type => !type.IsAbstract)
                         .Where(type => !type.IsInterface)
                         .Where(type => type != GetType())
                         .Select(type => Container.CreateInstance(type))
                         .Cast<IHttpClient>()
                         .ToList());
        }

        #endregion

        #region Properties

        private Lazy<List<IHttpClient>> AvailableClients { get; }

        #endregion

        #region Interface Implementations

        public bool CanGetResponse(IHttpRequest request)
        {
            return AvailableClients.Value.Any(client => client.CanGetResponse(request));
        }

        public IHttpResponse GetResponse(IHttpRequest request, Interfaces.Infrastructure.IProgress<double> progress)
        {
            return AvailableClients.Value.FirstOrDefault(client => client.CanGetResponse(request))?.GetResponse(request, progress);
        }

        #endregion
    }
}