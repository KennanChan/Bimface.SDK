using System;
using System.Collections.Generic;
using System.IO;
using Bimface.SDK.Interfaces.Infrastructure.Http;

namespace Bimface.SDK.Entities.Http
{
    internal abstract class HttpRequest : IHttpRequest
    {
        public long? GetContentLength()
        {
            throw new NotImplementedException();
        }

        public string GetContentType()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, string> GetHeaders()
        {
            throw new NotImplementedException();
        }

        public string GetMethod()
        {
            throw new NotImplementedException();
        }

        public IDictionary<string, string> GetQueries()
        {
            throw new NotImplementedException();
        }

        public Stream GetRequestStream()
        {
            throw new NotImplementedException();
        }

        public Uri GetUri()
        {
            throw new NotImplementedException();
        }

        public string GetUrl()
        {
            throw new NotImplementedException();
        }
    }
}