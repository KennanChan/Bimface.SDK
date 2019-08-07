#region

using System.IO;
using Bimface.SDK.Entities.Http;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpResponse
    {
        #region Others

        HttpContentType GetContentType();
        string GetHeader(string name);
        Stream GetResponseStream();
        int GetStatusCode();

        #endregion
    }
}