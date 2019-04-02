using System.Threading.Tasks;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

namespace Bimface.SDK.Interfaces.Infrastructure
{
    internal interface IRequestBuilder<in T> : IRequestBuilder where T : HttpParameter
    {
        Task<HttpRequest> Build(T parameter);
    }

    internal interface IRequestBuilder
    {
        void Init();
    }
}