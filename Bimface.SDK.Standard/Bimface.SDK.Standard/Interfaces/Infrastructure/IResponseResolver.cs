#region

using System.IO;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IResponseResolver
    {
        #region Others

        T Resolve<T>(IHttpResponse response);
        T Resolve<T>(Stream        content);

        #endregion
    }
}