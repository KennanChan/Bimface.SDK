#region

using System;
using System.IO;
using System.Linq;
using System.Net;
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
        #region Interface Implementations

        public IHttpResponse GetResponse(IHttpRequest request, IProgress<double> progress)
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

        #endregion

        #region Others

        private static HttpWebRequest SetBody(HttpWebRequest request, Stream body, IProgress<double> progress)
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
        protected virtual HttpWebRequest CreateRequest(IHttpRequest request, IProgress<double> progress)
        {
            var            uri = request.GetUri();
            HttpWebRequest realRequest;
            if (uri.Scheme == Uri.UriSchemeHttps)
            {
                realRequest                 = WebRequest.CreateHttp(uri);
                realRequest.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                realRequest = WebRequest.CreateHttp(request.GetUri());
            }

            realRequest.Method = request.GetMethod();
            var headers = request.GetHeaders();
            headers.Keys.ToList().ForEach(key => { realRequest.Headers.Add(key, headers[key]); });
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