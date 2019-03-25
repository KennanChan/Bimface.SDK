﻿using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Bimface.SDK.Attributes;

namespace Bimface.SDK.Extensions
{
    public static class ObjectExtensions
    {
        internal static IEnumerable<PropertyInfo> GetInjectableProperties(this object obj)
        {
            var properties = obj.GetType().GetProperties(BindingFlags.Instance |
                                                         BindingFlags.SetProperty |
                                                         BindingFlags.NonPublic |
                                                         BindingFlags.Public);
            return properties.Where(property => property.GetCustomAttributes(typeof(InjectAttribute), false).Any())
                .Where(property => property.GetValue(obj, null) == null);
        }
    }
}