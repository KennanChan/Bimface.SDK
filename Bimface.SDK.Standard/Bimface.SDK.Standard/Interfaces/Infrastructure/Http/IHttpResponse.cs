#region

using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpResponse
    {
        #region Others

        string GetHeader(string name);

        Stream GetResponseStream();
        int GetStatusCode();

        #endregion
    }
}