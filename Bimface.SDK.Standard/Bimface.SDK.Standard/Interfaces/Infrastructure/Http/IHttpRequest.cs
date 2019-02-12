#region

using System;
using System.Collections.Generic;
using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpRequest
    {
        long? GetContentLength();
        string GetContentType();
        string GetFullUrl();
        IDictionary<string, string> GetHeaders();
        string GetMethod();
        IDictionary<string, string> GetQueries();
        Stream GetRequestStream();
        Uri GetUri();
        string GetUrl();
    }
}