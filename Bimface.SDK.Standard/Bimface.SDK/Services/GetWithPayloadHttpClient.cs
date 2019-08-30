#if NETSTANDARD
#region

using System;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using System.IO;
using System.Linq;
using System.Net.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Extensions;

#endregion

namespace Bimface.SDK.Services
{
    internal class GetWithPayloadHttpClient : LogObject, IHttpClient
    {
        #region Constructors

        internal GetWithPayloadHttpClient()
        {
            Client = new HttpClient();
        }

        #endregion

        #region Properties

        private HttpClient Client { get; }

        #endregion

        #region Interface Implementations

        public bool CanGetResponse(IHttpRequest request)
        {
            return request.GetMethod() == HttpMethods.Get && request.GetBody() != null;
        }

        public IHttpResponse GetResponse(IHttpRequest request, Interfaces.Infrastructure.IProgress<double> progress = null)
        {
            #if DEBUG
            var time1 = DateTime.Now;
            #endif
            var requestMessage = new HttpRequestMessage(HttpMethod.Get, request.GetUri())
                                 {Content = new StreamContent(request.GetBody())};
            requestMessage.Headers.Clear();
            requestMessage.Content.Headers.Clear();
            request.GetHeaders().Where(header => !header.Key.StartsWith("Content")).ToList()
                   .ForEach(header => requestMessage.Headers.Add(header.Key, header.Value));
            request.GetHeaders().Where(header => header.Key.StartsWith("Content")).ToList()
                   .ForEach(header => requestMessage.Content.Headers.Add(header.Key, header.Value));
            var responseMessage = Client.SendAsync(requestMessage).Result;
            var response = new GetWithPayloadHttpResponse(responseMessage);
            #if DEBUG
            var time2 = DateTime.Now;
            Debug(
                $"[{(time2 - time1).TotalMilliseconds} ms]-[{request.GetMethod()}] {request.GetUri()} {Environment.NewLine} {response.GetResponseStream().AsString()}");
            #endif
            return response;
        }

        #endregion

        private class GetWithPayloadHttpResponse : IHttpResponse
        {
            #region Constructors

            public GetWithPayloadHttpResponse(HttpResponseMessage response)
            {
                Response = response;
            }

            #endregion

            #region Properties

            private HttpResponseMessage Response { get; }
            private MemoryStream Stream { get; set; }

            #endregion

            #region Interface Implementations

            public HttpContentType GetContentType()
            {
                var contentType = GetHeader("Content-Type");

                switch (contentType)
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
                return Response.Headers.GetValues("Content-Type").FirstOrDefault();
            }

            public Stream GetResponseStream()
            {
                if (null == Stream)
                {
                    Stream = new MemoryStream();
                    Response.Content.ReadAsStreamAsync().Result?.CopyTo(Stream);
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
}
#endif