#region

using System.Collections.Generic;
using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpResponse
    {
        IDictionary<string, string> GetHeaders();
        string GetHeader(string headerName);
        Stream GetResponseStream();
        int GetStatusCode();
    }
}