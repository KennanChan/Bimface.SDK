#region

using System;

#endregion

namespace Bimface.SDK.Attributes.Http
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HttpRequestAttribute : Attribute
    {
        #region Constructors

        public HttpRequestAttribute(string method, string host, string api)
        {
            Method = method;
            Api    = api;
            Host   = host;
        }

        #endregion

        #region Properties

        public string Api    { get; }
        public string Host   { get; }
        public string Method { get; }

        #endregion
    }
}