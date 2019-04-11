#region

using System;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpClient
    {
        #region Others

        IHttpResponse GetResponse(IHttpRequest request, IProgress<double> progress);

        #endregion
    }
}