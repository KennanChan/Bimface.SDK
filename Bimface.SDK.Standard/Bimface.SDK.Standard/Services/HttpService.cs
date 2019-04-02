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
        /// <returns></returns>
        protected async Task<T> FetchAsync<T>(HttpRequest request, IProgress<double> progress = null)
        {
            return await Task.Run(() => ResponseResolver.Resolve<T>(Client.GetResponse(request, progress)));
        }

        /// <summary>
        ///     Send an http request using the prebuilt <see cref="IRequestBuilder{T}"/> to build a request from the <see cref="TParameter"/>
        /// </summary>
        /// <typeparam name="TResult"></typeparam>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="parameter"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        protected async Task<TResult> FetchAsync<TResult, TParameter>(TParameter parameter, IProgress<double> progress = null)
            where TParameter : HttpParameter
        {
            var builder = Container.GetService<IRequestBuilder<TParameter>>();
            var request = await builder.Build(parameter);
            return await FetchAsync<TResult>(request);
        }

        /// <summary>
        ///     Send an http request without caring about the response
        /// </summary>
        /// <param name="request">The http request</param>
        /// <param name="progress"></param>
        /// <returns>The task </returns>
        protected async Task SendAsync(HttpRequest request, IProgress<double> progress = null)
        {
            await Task.Run(() => Client.GetResponse(request, null));
        }

        /// <summary>
        ///     Send an http request using the prebuilt <see cref="IRequestBuilder{T}"/> to build a request from the <see cref="TParameter"/>
        /// </summary>
        /// <typeparam name="TParameter"></typeparam>
        /// <param name="parameter"></param>
        /// <param name="progress"></param>
        /// <returns></returns>
        protected async Task SendAsync<TParameter>(TParameter parameter, IProgress<double> progress = null)
            where TParameter : HttpParameter
        {
            var builder = Container.GetService<IRequestBuilder<TParameter>>();
            var request = await builder.Build(parameter);
            await SendAsync(request);
        }

        #endregion
    }
}