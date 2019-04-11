using System.Linq;
using System.Reflection;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Interfaces.Infrastructure.Http;
using Bimface.SDK.Services;

namespace Bimface.SDK.Initializers
{
    internal class HttpContextInitializer : AppDomainServiceInitializer
    {
        protected override void HandleAssembly(Assembly assembly)
        {
            var baseType = typeof(IRequestPlugin);
            var context  = Container.GetService<IHttpContext>();
            assembly.GetTypes().Where(type => !type.IsAbstract)
                    .Where(type => !type.IsInterface)
                    .Where(type => baseType.IsAssignableFrom(type))
                    .ToList()
                    .ForEach(type =>
                     {
                         if (Container.GetService(type) is IRequestPlugin plugin)
                         {
                             context.UseRequestPlugin(plugin);
                         }
                         else
                         {
                             if (Container.CreateInstance(type) is IRequestPlugin requestPlugin)
                             {
                                 context.UseRequestPlugin(requestPlugin);
                                 Container.Singleton(requestPlugin.GetType(), requestPlugin);
                             }
                         }
                     });
        }

        protected override void Initialized()
        {

        }
    }
}