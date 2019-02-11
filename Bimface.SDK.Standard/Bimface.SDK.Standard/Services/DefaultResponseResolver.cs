using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

namespace Bimface.SDK.Services
{
    internal class DefaultResponseResolver : IResponseResolver
    {
        public DefaultResponseResolver(IJsonSerializer serializer)
        {
            Serializer = serializer;
        }

        private IJsonSerializer Serializer { get; }

        public T Resolve<T>(IHttpResponse response)
        {
            var contentStream = response.GetResponseStream();
            return Serializer.Deserialize<T>(contentStream.AsString());
        }
    }
}