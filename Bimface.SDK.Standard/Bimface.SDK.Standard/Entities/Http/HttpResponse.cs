#region

using System.IO;
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

        public Stream GetResponseStream()
        {
            return Response.GetResponseStream();
        }

        public int GetStatusCode()
        {
            return (int) Response.StatusCode;
        }

        public string GetHeader(string name)
        {
            return Response.Headers[name];
        }

        #endregion
    }
}