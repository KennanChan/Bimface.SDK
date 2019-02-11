#region

using System.Collections.Generic;
using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpResponse
    {
        string GetHeader(string headerName);
        IDictionary<string, string> GetHeaders();
        Stream GetResponseStream();
        int GetStatusCode();
    }
}