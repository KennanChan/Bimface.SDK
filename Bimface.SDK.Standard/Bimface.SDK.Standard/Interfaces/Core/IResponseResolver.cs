#region

using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IResponseResolver
    {
        #region Others

        T Resolve<T>(IHttpResponse response);

        #endregion
    }
}