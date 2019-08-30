#region

using System.Collections.Generic;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure.Http
{
    internal interface IHttpContext
    {
        #region Others

        IEnumerable<IRequestPlugin> GetRequestPlugins();
        void UseRequestPlugin(IRequestPlugin requestPlugin);

        #endregion
    }
}