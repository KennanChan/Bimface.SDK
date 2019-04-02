#region

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Services;

#endregion

namespace Bimface.SDK.Plugins
{
    /// <summary>
    ///     Plugin to automatically add predefined headers to an <see cref="HttpRequest" /> attributed with
    ///     <see cref="HttpHeaderAttribute" />
    /// </summary>
    internal class ResolveHeadersPlugin : AppDomainServiceInitializer, IRequestPlugin
    {
        #region Properties

        private Type BaseParameterType { get; } = typeof(HttpParameter);

        private ConcurrentDictionary<Type, List<KeyValuePair<string, string>>> Headers { get; } =
            new ConcurrentDictionary<Type, List<KeyValuePair<string, string>>>();

        #endregion

        #region Interface Implementations

        public Task Handle(HttpParameter parameter, HttpRequest request)
        {
            try
            {
                //Get all attributed headers
                var headerList = Headers.GetOrAdd(parameter.GetType(), HandleType);
                headerList.ForEach(header => request.AddHeader(header.Key, header.Value));
                return Task.FromResult(true);
            }
            catch (Exception e)
            {
                Error(e);
                return Task.FromResult(false);
            }
        }

        public void PreBuild()
        {
            Initialize(Container);
        }

        #endregion

        #region Others

        protected override void Handle(Assembly assembly)
        {
            assembly.GetTypes()
                    .Where(type => !type.IsInterface)
                    .Where(type => !type.IsAbstract)
                    .Where(type => BaseParameterType.IsAssignableFrom(type))
                    .ToList()
                    .ForEach(type =>
                     {
                         var headerList = HandleType(type);
                         Headers.AddOrUpdate(type, headerList, (t, h) => headerList);
                     });
        }

        private List<KeyValuePair<string, string>> HandleType(Type type)
        {
            var headers = type.GetCustomAttributes<HttpHeaderAttribute>(true);
            return headers.Select(header => new KeyValuePair<string, string>(header.Name, header.Value))
                          .ToList();
        }

        #endregion
    }
}