using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Interfaces.Infrastructure.Http;

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IRequestFactory
    {
        IHttpRequest GetRequest(IBimfaceParameter parameter);
    }
}