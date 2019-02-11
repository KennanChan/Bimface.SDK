#region

using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using System.Threading.Tasks;

#endregion

namespace Bimface.SDK.Services
{
    internal abstract class HttpService : LogObject
    {
        protected HttpService(IHttpClient client, IResponseResolver responseResolver)
        {
            Client = client;
            ResponseResolver = responseResolver;
        }

        protected IHttpClient Client { get; }
        protected IResponseResolver ResponseResolver { get; }

        protected async Task<T> FetchAsync<T>(IHttpRequest request)
        {
            return await Task.Run(() => Fetch<T>(request));
        }

        protected T Fetch<T>(IHttpRequest request)
        {
            var response = Client.GetResponse(request);
            return ResponseResolver.Resolve<T>(response);
        }

        protected void SendAsync(IHttpRequest request)
        {
            Task.Run(() => Send(request));
        }

        protected void Send(IHttpRequest request)
        {
            Client.GetResponse(request);
        }
    }
}