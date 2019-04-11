#region

using System;
using Bimface.SDK.Entities.Http;

#endregion

namespace Bimface.SDK.Attributes
{
    /// <summary>
    ///     Attribute to indicate the specific <see cref="HttpRequest" /> class should be sent with necessary Authorization
    ///     header
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class BimfaceAuthAttribute : Attribute
    {
        #region Properties

        public bool Enabled { get; set; } = true;

        #endregion
    }
}