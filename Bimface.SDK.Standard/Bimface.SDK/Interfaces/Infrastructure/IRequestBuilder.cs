#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure
{
    internal interface IRequestBuilder<in T> : IRequestBuilder where T : HttpParameter
    {
        #region Others

        Task<HttpRequest> Build(T parameter);

        #endregion
    }

    internal interface IRequestBuilder
    {
        #region Others

        void Init();

        #endregion
    }
}