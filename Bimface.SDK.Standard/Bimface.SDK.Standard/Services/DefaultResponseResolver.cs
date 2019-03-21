#region

using Bimface.SDK.Entities;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    internal class DefaultResponseResolver : IResponseResolver
    {
        #region Constructors

        public DefaultResponseResolver(IJsonSerializer serializer)
        {
            Serializer = serializer;
        }

        #endregion

        #region Properties

        private IJsonSerializer Serializer { get; }

        #endregion

        #region Interface Implementations

        public T Resolve<T>(IHttpResponse response)
        {
            var contentStream = response.GetResponseStream();
            return Serializer.Deserialize<GeneralResponse<T>>(contentStream.AsString()).Data;
        }

        #endregion
    }
}