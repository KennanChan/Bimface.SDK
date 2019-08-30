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
        private MemoryStream Stream { get; set; }

        #endregion

        #region Interface Implementations

        public HttpContentType GetContentType()
        {
            switch (Response.ContentType)
            {
                case "application/json":
                    return HttpContentType.Json;
                case "application/octet-stream":
                    return HttpContentType.Binary;
            }

            return HttpContentType.Binary;
        }

        public string GetHeader(string name)
        {
            return Response.Headers[name];
        }

        public Stream GetResponseStream()
        {
            if (null == Stream)
            {
                Stream = new MemoryStream();
                Response.GetResponseStream()?.CopyTo(Stream);
            }

            Stream.Seek(0, SeekOrigin.Begin);
            return Stream;
        }

        public int GetStatusCode()
        {
            return (int) Response.StatusCode;
        }

        #endregion
    }
}