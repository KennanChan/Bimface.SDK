#region

using System;

#endregion

namespace Bimface.SDK.Attributes.Http
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public class HttpHeaderAttribute : Attribute
    {
        #region Constructors

        public HttpHeaderAttribute(string name, string value)
        {
            Name  = name;
            Value = value;
        }

        #endregion

        #region Properties

        public string Name  { get; }
        public string Value { get; }

        #endregion
    }
}