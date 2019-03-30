#region

using System.Linq;
using System.Net;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     The default implementation of <see cref="IHttpClient" /> using the built-in <see cref="HttpWebRequest" />
    /// </summary>
    internal class DefaultHttpClient : IHttpClient
    {
        #region Interface Implementations

        public IHttpResponse GetResponse(IHttpRequest request)
        {
            var realRequest = CreateRequest(request);
            return GenerateResponse(realRequest.GetResponse() as HttpWebResponse);
        }

        #endregion

        #region Others

        /// <summary>
        ///     Create an <see cref="HttpWebRequest" /> from the given <see cref="IHttpRequest" /> instance
        /// </summary>
        /// <param name="request">The instance of <see cref="IHttpRequest" /></param>
        /// <returns>An instance of <see cref="HttpWebRequest" /></returns>
        protected virtual HttpWebRequest CreateRequest(IHttpRequest request)
        {
            var realRequest = WebRequest.CreateHttp(request.GetUri());
            realRequest.Method = request.GetMethod();
            var headers = request.GetHeaders();
            headers.Keys.ToList().ForEach(key => { realRequest.Headers.Add(key, headers[key]); });
            return realRequest;
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