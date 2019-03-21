#region

using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpResponse
    {
        #region Properties

        Stream GetResponseStream();
        int GetStatusCode();

        #endregion

        string GetHeader(string name);
    }
}