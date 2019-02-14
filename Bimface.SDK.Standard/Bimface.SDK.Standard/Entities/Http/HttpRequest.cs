#region

using System;
using System.Collections.Generic;
using System.IO;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Entities.Http
{
    public abstract class HttpRequest : IHttpRequest
    {
        #region Fields

        #endregion

        #region Interface Implementations

        public virtual long? GetContentLength()
        {
            return GetRequestStream()?.Length;
        }

        public virtual string GetContentType()
        {
            return "application/json";
        }

        public string GetFullUrl()
        {
            throw new NotImplementedException();
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

        #endregion

        protected void AddHeader(string name, string value)
        {
        }
    }
}