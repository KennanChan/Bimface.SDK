#region

using System;
using System.Collections.Generic;
using System.Linq;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class TypeExtensions
    {
        #region Others

        public static bool IsConcrete(this Type type)
        {
            return !type.IsAbstract && !type.IsInterface;
        }

        #endregion
    }
}