#region

using System;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    public interface IHttpClient
    {
        #region Others

        bool CanGetResponse(IHttpRequest       request);
        IHttpResponse GetResponse(IHttpRequest request, IProgress<double> progress = null);

        #endregion
    }
}