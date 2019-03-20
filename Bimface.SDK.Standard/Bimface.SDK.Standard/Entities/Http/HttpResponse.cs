#region

using Bimface.SDK.Interfaces.Infrastructure.Http;
using System.IO;
using System.Net;

#endregion

namespace Bimface.SDK.Entities.Http
{
    public class HttpResponse : IHttpResponse
    {
        private Stream _body;

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

        #endregion

        public Stream Body
        {
            get => _body ?? Response.GetResponseStream();
            internal set => _body = value;
        }

        public int StatusCode => (int)Response.StatusCode;

        public string GetHeader(string name)
        {
            return Response.Headers[name];
        }
    }
}