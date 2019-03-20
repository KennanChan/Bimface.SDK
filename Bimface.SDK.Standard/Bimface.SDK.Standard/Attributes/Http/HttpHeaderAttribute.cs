using System;

namespace Bimface.SDK.Attributes.Http
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class HttpHeaderAttribute : Attribute
    {
        public HttpHeaderAttribute(string name, string value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public string Value { get; }
    }
}