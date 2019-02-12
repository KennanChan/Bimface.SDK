#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    internal abstract class HttpService : LogObject
    {
        #region Constructors

        protected HttpService(IHttpClient client, IResponseResolver responseResolver)
        {
            Client           = client;
            ResponseResolver = responseResolver;
        }

        #endregion

        #region Properties

        protected IHttpClient       Client           { get; }
        protected IResponseResolver ResponseResolver { get; }

        #endregion

        protected T Fetch<T>(IHttpRequest request)
        {
            var response = Client.GetResponse(request);
            return ResponseResolver.Resolve<T>(response);
        }

        protected async Task<T> FetchAsync<T>(IHttpRequest request)
        {
            return await Task.Run(() => Fetch<T>(request));
        }

        protected void Send(IHttpRequest request)
        {
            Client.GetResponse(request);
        }

        protected void SendAsync(IHttpRequest request)
        {
            Task.Run(() => Send(request));
        }
    }
}