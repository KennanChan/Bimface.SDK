using System.Collections.Generic;

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    internal interface IHttpContext
    {
        void UseMiddleware(IMiddleware middleware);
        IEnumerable<IMiddleware> GetMiddlewares();
    }
}
