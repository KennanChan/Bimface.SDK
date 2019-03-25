using System;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure.Http;

namespace Bimface.SDK.Requests
{
    internal class RequestFactory : IRequestFactory
    {
        public IHttpRequest GetRequest(IBimfaceParameter parameter)
        {
            throw new NotImplementedException();
        }
    }
}
