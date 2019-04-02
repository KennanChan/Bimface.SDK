#region

using System;

#endregion

namespace Bimface.SDK.Attributes.Http
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public abstract class HttpComponentAttribute : Attribute
    {
        #region Constructors

        #endregion

        #region Properties

        public string Alias { get; set; }

        #endregion
    }
}