#region

using System.IO;
using Bimface.SDK.Entities;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
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
    internal class DefaultResponseResolver : LogObject, IResponseResolver
    {
        #region Properties

        private IJsonSerializer Serializer => Container.GetService<IJsonSerializer>();

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
            return Resolve<T>(response.GetResponseStream());
        }

        public T Resolve<T>(Stream content)
        {
            var s = content.AsString();
            Debug(s);
            var res = Serializer.Deserialize<GeneralResponse<T>>(s);
            if (res.Code == "success")
                return res.Data;
            throw new BimfaceException(res.Code, res.Message);
        }

        #endregion
    }
}