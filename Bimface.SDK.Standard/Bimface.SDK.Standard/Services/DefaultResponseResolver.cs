#region

using Bimface.SDK.Entities;
using Bimface.SDK.Exceptions;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Core;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    /// <summary>
    ///     The default implementation of <see cref="IResponseResolver" /> to resolve the <see cref="IHttpResponse" /> to
    ///     <see cref="GeneralResponse{T}" />
    /// </summary>
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

        /// <summary>
        ///     Deserialize the content of the <see cref="IHttpResponse" /> to <see cref="GeneralResponse{T}" /> using the
        ///     <see cref="IJsonSerializer" />
        /// </summary>
        /// <typeparam name="T">The type of the data</typeparam>
        /// <param name="response">The <see cref="IHttpResponse" /> instance</param>
        /// <returns></returns>
        public T Resolve<T>(IHttpResponse response)
        {
            var contentStream = response.GetResponseStream();
            var res           = Serializer.Deserialize<GeneralResponse<T>>(contentStream.AsString());
            if (res.Code == "success")
                return res.Data;
            throw new BimfaceException(res.Code, res.Message);
        }

        #endregion
    }
}