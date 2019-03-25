using System.Collections.Generic;

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    internal interface IHttpContext
    {
        IEnumerable<IRequestPlugin> GetRequestPlugins();
        void UseRequestPlugin(IRequestPlugin requestPlugin);
    }
}