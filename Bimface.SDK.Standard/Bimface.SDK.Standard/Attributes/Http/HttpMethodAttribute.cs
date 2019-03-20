using System;

namespace Bimface.SDK.Attributes.Http
{
    [AttributeUsage(AttributeTargets.Class)]
    public class HttpMethodAttribute : Attribute
    {
        public HttpMethodAttribute(string method)
        {
            Method = method;
        }

        public string Method { get; }
    }
}
