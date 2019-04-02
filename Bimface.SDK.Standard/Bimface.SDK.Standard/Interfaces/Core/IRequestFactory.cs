#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IRequestFactory
    {
        #region Others

        Task<IHttpRequest> GetRequest<T>(T parameter) where T : HttpParameter;

        #endregion
    }
}