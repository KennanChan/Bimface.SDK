#region

using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Entities.Http
{
    public class HttpResponse : IHttpResponse
    {
        #region Constructors

        internal HttpResponse(HttpWebResponse response)
        {
            Response = response;
        }

        #endregion

        #region Properties

        private HttpWebResponse Response { get; }

        #endregion

        #region Interface Implementations

        public string GetHeader(string headerName)
        {
            return Response.GetResponseHeader(headerName);
        }

        public IDictionary<string, string> GetHeaders()
        {
            return Response.Headers.AllKeys.ToDictionary(key => key, key => Response.Headers[key]);
        }

        public Stream GetResponseStream()
        {
            return Response.GetResponseStream();
        }

        public int GetStatusCode()
        {
            return (int) Response.StatusCode;
        }

        #endregion
    }
}