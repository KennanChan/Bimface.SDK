#region

using System.IO;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpResponse
    {
        #region Properties

        Stream Body { get; }
        int StatusCode { get; }

        #endregion

        string GetHeader(string name);
    }
}