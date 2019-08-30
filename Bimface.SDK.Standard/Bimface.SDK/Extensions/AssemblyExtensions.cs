using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Bimface.SDK.Extensions
{
    public static class AssemblyExtensions
    {
        public static IEnumerable<Type> GetConcreteTypes<T>(this Assembly assembly)
        {
            return assembly.GetTypes().Where(type => type.IsConcrete() && typeof(T).IsAssignableFrom(type));
        }
    }
}
