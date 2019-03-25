#region

using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpResponse
    {
        string GetHeader(string name);

        Stream GetResponseStream();
        int GetStatusCode();
    }
}