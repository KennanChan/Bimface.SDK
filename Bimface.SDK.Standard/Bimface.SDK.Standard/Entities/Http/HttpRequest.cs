using Bimface.SDK.Interfaces.Infrastructure.Http;
using System;
using System.Collections.Generic;
using System.IO;

namespace Bimface.SDK.Entities.Http
{
    public abstract class HttpRequest : IHttpRequest
    {
        private Dictionary<string, string> _headers;
        private long? _contentLength;
        private string _contentType;
        #region Interface Implementations

        public virtual long? GetContentLength()
        {
            return GetRequestStream()?.Length;
        }

        public virtual string GetContentType()
        {
            return "application/json";
        }

        public virtual IDictionary<string, string> GetHeaders()
        {
            throw new NotImplementedException();
        }

        public virtual string GetMethod()
        {
            throw new NotImplementedException();
        }

        public virtual IDictionary<string, string> GetQueries()
        {
            throw new NotImplementedException();
        }

        public virtual Stream GetRequestStream()
        {
            throw new NotImplementedException();
        }

        public virtual Uri GetUri()
        {
            throw new NotImplementedException();
        }

        public virtual string GetUrl()
        {
            throw new NotImplementedException();
        }

        protected void AddHeader(string name, string value)
        {

        }

        #endregion
    }
}