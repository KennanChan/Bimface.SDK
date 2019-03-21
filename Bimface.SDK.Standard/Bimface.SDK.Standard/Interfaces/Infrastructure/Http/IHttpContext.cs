using System.Collections.Generic;

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    internal interface IHttpContext
    {
        void UseRequestPlugin(IRequestPlugin requestPlugin);
        IEnumerable<IRequestPlugin> GetRequestPlugins();
    }
}
