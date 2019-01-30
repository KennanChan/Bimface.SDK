using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Bimface.SDK.Interfaces.Infrastructure.Http;

namespace Bimface.SDK.Entities.Http
{
    internal class HttpResponse : IHttpResponse
    {
        private HttpWebResponse Response { get; }

        internal HttpResponse(HttpWebResponse response)
        {
            Response = response;
        }

        public IDictionary<string, string> GetHeaders()
        {
            return Response.Headers.AllKeys.ToDictionary(key => key, key => Response.Headers[key]);
        }

        public string GetHeader(string headerName)
        {
            return Response.GetResponseHeader(headerName);
        }

        public Stream GetResponseStream()
        {
            return Response.GetResponseStream();
        }

        public int GetStatusCode()
        {
            return (int) Response.StatusCode;
        }
    }
}