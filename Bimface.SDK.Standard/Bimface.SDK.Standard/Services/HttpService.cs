#region

using System.Threading.Tasks;
using Bimface.SDK.Attributes;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     A base service to interact with server using HTTP
    /// </summary>
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

        [Inject]
        internal IHttpContext Context { get; set; }

        #endregion

        /// <summary>
        ///     Send an http request and wait to fetch some data from the response
        /// </summary>
        /// <typeparam name="T">The type of the data</typeparam>
        /// <param name="request">The http request</param>
        /// <returns></returns>
        protected async Task<T> FetchAsync<T>(HttpRequest request)
        {
            await RunPlugins(request);
            await ConfigureRequest(request);
            return await Task.Run(() => ResponseResolver.Resolve<T>(Client.GetResponse(request)));
        }

        /// <summary>
        ///     Send an http request without caring about the response
        /// </summary>
        /// <param name="request">The http request</param>
        /// <returns>The task </returns>
        protected async Task SendAsync(HttpRequest request)
        {
            await RunPlugins(request);
            await ConfigureRequest(request);
            await Task.Run(() => Client.GetResponse(request));
        }

        /// <summary>
        ///     Run all the registered <see cref="IRequestPlugin"/> on the <see cref="HttpRequest"/>
        /// </summary>
        /// <param name="request">The http request</param>
        /// <returns></returns>
        private async Task RunPlugins(HttpRequest request)
        {
            var plugins = Context.GetRequestPlugins();
            foreach (var plugin in plugins)
            {
                await plugin.Handle(request);
            }
        }

        private async Task ConfigureRequest(HttpRequest request)
        {
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (request is IHttpConfigurable configurable)
            {
                await configurable.Configure();
            }
        }
    }
}