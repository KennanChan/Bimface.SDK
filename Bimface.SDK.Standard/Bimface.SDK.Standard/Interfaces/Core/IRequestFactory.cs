#region

using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Interfaces.Core
{
    internal interface IRequestFactory
    {
        #region Others

        IHttpRequest GetRequest(IBimfaceParameter parameter);

        #endregion
    }
}