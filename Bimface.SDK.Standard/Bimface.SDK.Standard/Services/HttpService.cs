#region

using System;
using System.Threading.Tasks;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
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
        #region Properties

        protected IHttpClient       Client           => Container.GetService<IHttpClient>();
        protected IResponseResolver ResponseResolver => Container.GetService<IResponseResolver>();

        #endregion

        #region Others

        /// <summary>
        ///     Send an http request and wait to fetch some data from the response
        /// </summary>
        /// <typeparam name="T">The type of the data</typeparam>
        /// <param name="request">The http request</param>
        /// <param name="progress">The progress handler</param>
        /// <returns>The data returned from the server</returns>
        protected async Task<T> FetchAsync<T>(HttpRequest request, IProgress<double> progress = null)
        {
            return await Task.Run(() => ResponseResolver.Resolve<T>(Client.GetResponse(request, progress))).ConfigureAwait(false);
        }

        /// <summary>
        ///     Send an http request using the prebuilt <see cref="IRequestBuilder{T}" /> to build a request from the <typeparamref name="TParameter"/>
        /// </summary>
        /// <typeparam name="TResult">The type of the result</typeparam>
        /// <typeparam name="TParameter">The type of the parameter</typeparam>
        /// <param name="parameter">The parameter instance</param>
        /// <param name="progress">The progress reporter</param>
        /// <returns>The data returned from the server</returns>
        protected async Task<TResult> FetchAsync<TResult, TParameter>(TParameter parameter, IProgress<double> progress = null)
            where TParameter : HttpParameter
        {
            return await Task.Run(async () => ResponseResolver.Resolve<TResult>(Client.GetResponse(await CreateHttpRequest(parameter), progress)));
        }

        /// <summary>
        ///     Send an http request without caring about the response
        /// </summary>
        /// <param name="request">The http request</param>
        /// <param name="progress">The progress reporter</param>
        /// <returns>The task used to wait</returns>
        protected async Task SendAsync(HttpRequest request, IProgress<double> progress = null)
        {
            await Task.Run(() => Client.GetResponse(request, null)).ConfigureAwait(false);
        }

        /// <summary>
        ///     Send an http request using the prebuilt <see cref="IRequestBuilder{T}" /> to build a request from the
        ///     <typeparamref name="TParameter"/>
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="parameter"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        protected async Task SendAsync<TParameter>(TParameter parameter, IProgress<double> progress = null)
            where TParameter : HttpParameter
        {
            await Task.Run(async () => Client.GetResponse(await CreateHttpRequest(parameter), null));
        }

        /// <summary>
        ///     Create an <see cref="HttpRequest" /> from an <see cref="HttpParameter" />
        /// </summary>
        /// <typeparam name="TParameter">The type of the <see cref="HttpParameter" /></typeparam>
        /// <param name="parameter">The <see cref="HttpParameter" /> instance</param>
        /// <returns></returns>
        private Task<HttpRequest> CreateHttpRequest<TParameter>(TParameter parameter)
            where TParameter : HttpParameter
        {
#if DEBUG
            var time1 = DateTime.Now;
#endif
            var builder = Container.GetService<IRequestBuilder<TParameter>>();
            var request = builder.Build(parameter);
#if DEBUG
            var time2 = DateTime.Now;
            Debug($"Create request for [{parameter.GetType().Name}] in {(time2 - time1).TotalMilliseconds}ms");
#endif
            return request;
        }

        #endregion
    }
}