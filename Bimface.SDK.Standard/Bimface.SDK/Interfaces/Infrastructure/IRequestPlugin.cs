﻿#region

using System.Threading.Tasks;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;

#endregion

namespace Bimface.SDK.Interfaces.Infrastructure
{
    public interface IRequestPlugin
    {
        #region Others

        Task HandleRequest(HttpParameter parameter, HttpRequest request);

        #endregion
    }
}