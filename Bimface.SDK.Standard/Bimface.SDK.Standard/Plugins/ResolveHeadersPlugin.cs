#region

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Bimface.SDK.Attributes.Http;
using Bimface.SDK.Entities.Http;
using Bimface.SDK.Entities.Internal;
using Bimface.SDK.Interfaces.Infrastructure;

#endregion

namespace Bimface.SDK.Plugins
{
    /// <summary>
    ///     Plugin to automatically add predefined headers to an <see cref="HttpRequest" /> attributed with
    ///     <see cref="HttpHeaderAttribute" />
    /// </summary>
    internal class ResolveHeadersPlugin : LogObject, IRequestPlugin, IDisposable
    {
        #region Properties

        private Type BaseRequestType { get; } = typeof(HttpRequest);

        private ConcurrentDictionary<Type, List<KeyValuePair<string, string>>> Headers { get; } =
            new ConcurrentDictionary<Type, List<KeyValuePair<string, string>>>();

        #endregion

        #region Interface Implementations

        public void Dispose()
        {
            AppDomain.CurrentDomain.AssemblyLoad -= CurrentDomain_AssemblyLoad;
            Headers.Clear();
        }

        public Task<bool> Handle(HttpRequest request)
        {
            try
            {
                //Get all attributed headers
                var headerList = Headers.GetOrAdd(request.GetType(), HandleType);
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
            AppDomain.CurrentDomain.GetAssemblies().ToList().ForEach(AnalyzeAssembly);
            AppDomain.CurrentDomain.AssemblyLoad += CurrentDomain_AssemblyLoad;
        }

        #endregion

        #region Others

        private void AnalyzeAssembly(Assembly assembly)
        {
            assembly.GetTypes()
                    .Where(type => !type.IsInterface)
                    .Where(type => !type.IsAbstract)
                    .Where(type => BaseRequestType.IsAssignableFrom(type))
                    .ToList()
                    .ForEach(type =>
                     {
                         var headerList = HandleType(type);
                         Headers.AddOrUpdate(type, headerList, (t, h) => headerList);
                     });
        }

        private void CurrentDomain_AssemblyLoad(object sender, AssemblyLoadEventArgs args)
        {
            AnalyzeAssembly(args.LoadedAssembly);
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