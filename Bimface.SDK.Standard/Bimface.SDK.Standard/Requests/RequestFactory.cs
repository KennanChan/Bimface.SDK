#region

using System;
using System.Collections.Concurrent;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Requests
{
    internal class RequestFactory : IRequestFactory
    {
        #region Properties

        private ConcurrentDictionary<Type, Func<IBimfaceParameter, IHttpRequest>> Creators { get; } =
            new ConcurrentDictionary<Type, Func<IBimfaceParameter, IHttpRequest>>();

        #endregion

        #region Interface Implementations

        public IHttpRequest GetRequest(IBimfaceParameter parameter)
        {
            var type    = parameter.GetType();
            var creator = Creators.GetOrAdd(type, CreateRequest);
            return creator?.Invoke(parameter);
        }

        #endregion

        #region Others

        private IHttpRequest CreateRequest(IBimfaceParameter parameter)
        {
        }

        #endregion
    }
}