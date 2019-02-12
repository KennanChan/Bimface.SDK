#region

using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    public interface IResponseResolver
    {
        T Resolve<T>(IHttpResponse response);
    }
}