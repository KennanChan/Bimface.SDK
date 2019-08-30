#region

using System;
using System.Net;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services.Internal
{
    internal abstract class HttpHeaderNameHandler : LogObject, IHttpHeaderHandler
    {
        #region Properties

        protected abstract string TargetKey { get; }

        #endregion

        #region Interface Implementations

        public bool CanSetHeader(HttpWebRequest request, string key)
        {
            return string.Equals(key, TargetKey, StringComparison.InvariantCultureIgnoreCase);
        }

        public abstract void SetHeader(HttpWebRequest request, string key, string value);

        #endregion
    }
}