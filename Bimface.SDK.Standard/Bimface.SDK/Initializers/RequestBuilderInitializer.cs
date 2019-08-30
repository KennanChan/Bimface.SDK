using System.Linq;
using System.Reflection;
using Bimface.SDK.Entities.Parameters.Base;
using Bimface.SDK.Extensions;
using Bimface.SDK.Interfaces.Infrastructure;
using Bimface.SDK.Services;

namespace Bimface.SDK.Initializers
{
    internal class RequestBuilderInitializer : AppDomainServiceInitializer
    {
        protected override void HandleAssembly(Assembly assembly)
        {
            var baseType             = typeof(HttpParameter);
            var genericInterfaceType = typeof(IRequestBuilder<>);
            var genericType          = typeof(RequestBuilder<>);
            assembly.GetTypes().Where(type => !type.IsAbstract)
                    .Where(type => !type.IsInterface)
                    .Where(type => baseType.IsAssignableFrom(type))
                    .ToList()
                    .ForEach(type =>
                     {
                         var typeArgs             = new[] {type};
                         var builderInterfaceType = genericInterfaceType.MakeGenericType(typeArgs);
                         var builderType          = genericType.MakeGenericType(typeArgs);
                         var builder              = Container.CreateInstance(builderType) as IRequestBuilder;
                         builder?.Init();
                         Container.AddService(builderInterfaceType, builder);
                     });
        }

        protected override void Initialized()
        {

        }
    }
}