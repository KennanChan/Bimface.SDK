#region

using System;
using System.Collections.Generic;
using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpRequest
    {
        #region Others

        Stream GetBody();
        IDictionary<string, string> GetHeaders();
        string GetMethod();
        Uri GetUri();

        #endregion
    }
}