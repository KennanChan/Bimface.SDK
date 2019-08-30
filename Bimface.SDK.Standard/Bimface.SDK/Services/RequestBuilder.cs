#region

using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;

#endregion

namespace Bimface.SDK.Services
{
    internal class RequestBuilder<T> : LogObject, IRequestBuilder<T> where T : HttpParameter
    {
        #region Constructors

        public RequestBuilder(IHttpContext context)
        {
            Context = context;
        }

        #endregion

        #region Properties

        private ConcurrentDictionary<string, HttpComponentInfo> Components { get; }
            = new ConcurrentDictionary<string, HttpComponentInfo>();

        private IHttpContext Context { get; }

        private ConcurrentDictionary<string, Func<T, object>> Getters { get; }
            = new ConcurrentDictionary<string, Func<T, object>>();

        private string      Host          { get; set; }
        private string      Method        { get; set; }
        private INamingRule NamingRule    => Container.GetService<INamingRule>();
        private Type        ParameterType { get; } = typeof(T);
        private string      UrlPattern    { get; set; }

        #endregion

        #region Interface Implementations

        public void Init()
        {
            var requestAttribute = ParameterType.CustomAttribute<HttpRequestAttribute>(true);
            if (null != requestAttribute)
            {
                UrlPattern = requestAttribute.Api;
                Method     = requestAttribute.Method;
                Host       = requestAttribute.Host;
                ParameterType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance).ToList().ForEach(propertyInfo =>
                {
                    var propertyName = propertyInfo.Name;
                    var getter       = ResolveGetter(propertyInfo);
                    Getters.AddOrUpdate(propertyName, getter, (k, v) => getter);
                    var attribute = propertyInfo.CustomAttribute<HttpComponentAttribute>(true);
                    if (null == attribute) return;
                    var component = new HttpComponentInfo(propertyName, attribute, NamingRule);
                    Components.AddOrUpdate(propertyName, component, (p, a) => component);
                });
            }
        }

        public async Task<HttpRequest> Build(T parameter)
        {
            var request = new HttpRequest(Method, Host, BuildUrl(parameter));
            Container.InjectProperties(request);
            BuildQueries(parameter, request);
            BuildHeaders(parameter, request);
            BuildBody(parameter, request);
            await RunPlugins(parameter, request);
            return request;
        }

        #endregion

        #region Others

        internal object GetValue(T value, string propertyName)
        {
            var getter = Getters.GetOrAdd(propertyName, name =>
            {
                var propertyInfo = GetType().GetProperty(name);
                return ResolveGetter(propertyInfo);
            });
            return getter.Invoke(value);
        }

        private void BuildBody(T parameter, HttpRequest request)
        {
            var bodies = Components.Where(c => c.Value.Attribute is HttpBodyComponentAttribute).ToArray();
            if (bodies.Any())
            {
                var body  = bodies.First();
                var value = GetValue(parameter, body.Key);
                if (((HttpBodyComponentAttribute) body.Value.Attribute).ContentType == HttpContentType.Binary)
                {
                    if (value is Stream stream)
                    {
                        request.AddBody(stream);
                    }
                }
                else
                    request.AddJsonBody(value);
            }
        }

        private void BuildHeaders(T parameter, HttpRequest request)
        {
            Components.Where(c => c.Value.Attribute is HttpHeaderComponentAttribute)
                      .ToList().ForEach(c => request.AddHeader(c.Value.Name, GetValue(parameter, c.Key).ToString()));
        }

        private void BuildQueries(T parameter, HttpRequest request)
        {
            Components.Where(c => c.Value.Attribute is HttpQueryComponentAttribute)
                      .ToList().ForEach(c => request.AddQuery(c.Value.Name, GetValue(parameter, c.Key)));
        }

        private string BuildUrl(T parameter)
        {
            return Components.Where(c => c.Value.Attribute is HttpPathComponentAttribute)
                             .Aggregate(UrlPattern,
                                  (result, c) => result.Replace($"{{{c.Value.Name}}}", GetValue(parameter, c.Key).ToString()));
        }

        private Func<T, object> ResolveGetter(PropertyInfo propertyInfo)
        {
            var getMethod = propertyInfo.GetGetMethod(false) ?? propertyInfo.GetGetMethod(true);
            if (!getMethod.ReturnType.IsValueType)
            {
                return (Func<T, object>) Delegate.CreateDelegate(typeof(Func<T, object>), null,
                    getMethod);
            }

            return propertyInfo.GetPropertyValue;
        }

        /// <summary>
        ///     Run all the registered <see cref="IRequestPlugin" /> on the <see cref="HttpRequest" />
        /// </summary>
        /// <param name="parameter">The instance of <see cref="HttpParameter" /></param>
        /// <param name="request">The http request</param>
        /// <returns></returns>
        private async Task RunPlugins(HttpParameter parameter, HttpRequest request)
        {
            var plugins = Context.GetRequestPlugins();
            foreach (var plugin in plugins)
            {
                await plugin.HandleRequest(parameter, request);
            }
        }

        #endregion

        private class HttpComponentInfo
        {
            #region Constructors

            public HttpComponentInfo(string propertyName, HttpComponentAttribute attribute, INamingRule namingRule)
            {
                Name      = string.IsNullOrWhiteSpace(attribute.Alias) ? namingRule?.Naming(propertyName) ?? propertyName : attribute.Alias;
                Attribute = attribute;
            }

            #endregion

            #region Properties

            public HttpComponentAttribute Attribute { get; }

            public string Name { get; }

            #endregion
        }
    }
}