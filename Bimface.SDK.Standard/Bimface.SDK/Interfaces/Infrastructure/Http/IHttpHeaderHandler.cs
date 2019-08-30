#region

using System.Net;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    internal interface IHttpHeaderHandler
    {
        #region Others

        bool CanSetHeader(HttpWebRequest request, string key);
        void SetHeader(HttpWebRequest    request, string key, string value);

        #endregion
    }
}