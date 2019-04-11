#region

using System;

#endregion

namespace Bimface.SDK.Attributes.Http
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HttpRequestAttribute : Attribute
    {
        #region Constructors

        public HttpRequestAttribute(string method, string host, string absoluteApi)
        {
            Method = method;
            Api    = absoluteApi;
            Host   = host;
        }

        #endregion

        #region Properties

        public string Api    { get; set; }
        public string Host   { get; set; }
        public string Method { get; set; }

        #endregion
    }
}