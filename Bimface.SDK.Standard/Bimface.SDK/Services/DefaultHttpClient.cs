#region

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     The default implementation of <see cref="IHttpClient" /> using the built-in <see cref="HttpWebRequest" />
    /// </summary>
    internal class DefaultHttpClient : LogObject, IHttpClient
    {
        #region Fields

        private HashSet<IHttpHeaderHandler> _headerHandlers;

        #endregion

        #region Constructors

        public DefaultHttpClient()
        {
            Assembly.GetExecutingAssembly().GetConcreteTypes<IHttpHeaderHandler>().ToList()
                    .ForEach(type => HeaderHandlers.Add((IHttpHeaderHandler) Activator.CreateInstance(type)));
        }

        #endregion

        #region Properties

        private HashSet<IHttpHeaderHandler> HeaderHandlers => _headerHandlers ?? (_headerHandlers = new HashSet<IHttpHeaderHandler>());

        #endregion

        #region Interface Implementations

        public bool CanGetResponse(IHttpRequest request)
        {
            if (request.GetMethod() == HttpMethods.Get)
            {
                return request.GetBody() == null;
            }

            return true;
        }

        public IHttpResponse GetResponse(IHttpRequest request, Interfaces.Infrastructure.IProgress<double> progress)
        {
            try
            {
                var realRequest = CreateRequest(request, progress);
#if DEBUG
                var time1 = DateTime.Now;
#endif
                var response = GenerateResponse(realRequest.GetResponse() as HttpWebResponse);
#if DEBUG
                var time2 = DateTime.Now;
                Debug(
                    $"[{(time2 - time1).TotalMilliseconds} ms]-[{request.GetMethod()}] {request.GetUri()} {Environment.NewLine} {response.GetResponseStream().AsString()}");
#endif
                return response;
            }
            catch (WebException e)
            {
                Error(e.Response.GetResponseStream().AsString());
                throw;
            }
        }

        #endregion

        #region Others

        private static HttpWebRequest SetBody(HttpWebRequest request, Stream body, Interfaces.Infrastructure.IProgress<double> progress)
        {
            if (body != null && body.Length > 0)
            {
                //Ensure that we have ContentLength set in the headers
                if (request.ContentLength == 0)
                    request.ContentLength = body.Length;

                //Upload and handle progress
                var requestStream = request.GetRequestStream();
                var total         = body.Length;
                body.Seek(0, SeekOrigin.Begin);
                body.CopyTo(requestStream, 4096, bytes => progress?.Report(bytes * 1.0 / total));
                body.Close();
                requestStream.Close();
            }

            return request;
        }

        /// <summary>
        ///     Create an <see cref="HttpWebRequest" /> from the given <see cref="IHttpRequest" /> instance
        /// </summary>
        /// <param name="request">The instance of <see cref="IHttpRequest" /></param>
        /// <param name="progress">The progress reporter</param>
        /// <returns>An instance of <see cref="HttpWebRequest" /></returns>
        protected virtual HttpWebRequest CreateRequest(IHttpRequest request, Interfaces.Infrastructure.IProgress<double> progress)
        {
            var            uri = request.GetUri();
            HttpWebRequest realRequest;
            if (uri.Scheme == Uri.UriSchemeHttps)
            {
                realRequest                 = (HttpWebRequest) WebRequest.Create(uri);
                realRequest.ProtocolVersion = HttpVersion.Version11;
            }
            else
            {
                realRequest = (HttpWebRequest) WebRequest.Create(request.GetUri());
            }

            realRequest.Method = request.GetMethod();
            var headers = request.GetHeaders();
            headers.Keys.ToList().ForEach(key =>
            {
                var handler = HeaderHandlers.FirstOrDefault(h => h.CanSetHeader(realRequest, key));
                if (null != handler)
                    handler.SetHeader(realRequest, key, headers[key]);
                else
                    realRequest.Headers.Add(key, headers[key]);
            });
            return SetBody(realRequest, request.GetBody(), progress);
        }

        /// <summary>
        ///     Create an <see cref="IHttpResponse" /> from the given <see cref="HttpWebResponse" /> instance
        /// </summary>
        /// <param name="response">The instance of <see cref="HttpWebResponse" /></param>
        /// <returns>An instance of <see cref="IHttpResponse" /></returns>
        protected virtual IHttpResponse GenerateResponse(HttpWebResponse response)
        {
            return new HttpResponse(response);
        }

        #endregion
    }
}