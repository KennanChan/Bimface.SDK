#region

using System.Linq;
using System.Net;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    internal class HttpClient : IHttpClient
    {
        #region Interface Implementations

        public IHttpResponse Request(IHttpRequest request)
        {
            var realRequest = CreateRequest(request);
            return GenerateResponse(realRequest.GetResponse() as HttpWebResponse);
        }

        #endregion

        protected virtual HttpWebRequest CreateRequest(IHttpRequest request)
        {
            var realRequest = WebRequest.CreateHttp(request.GetUri());
            realRequest.Method        = request.GetMethod();
            realRequest.ContentLength = request.GetContentLength() ?? 0;
            var headers = request.GetHeaders();
            headers.Keys.ToList().ForEach(key => { realRequest.Headers.Add(key, headers[key]); });
            return realRequest;
        }

        protected virtual IHttpResponse GenerateResponse(HttpWebResponse response)
        {
            return new HttpResponse(response);
        }
    }
}