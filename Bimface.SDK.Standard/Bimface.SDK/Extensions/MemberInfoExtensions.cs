#region

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class MemberInfoExtensions
    {
        #region Others

        public static T CustomAttribute<T>(this MemberInfo member, bool inherit) where T : Attribute
        {
#if NET40
            return member.GetCustomAttributes(inherit).Where(attr => attr is T).Cast<T>().FirstOrDefault();
#else
            return member.GetCustomAttribute<T>(inherit);
#endif
        }

        public static IEnumerable<T> CustomAttributes<T>(this MemberInfo member, bool inherit) where T : Attribute
        {
#if NET40
            return member.GetCustomAttributes(inherit).Where(attr => attr is T).Cast<T>();
#else
            return member.GetCustomAttributes<T>(inherit);
#endif
        }

        #endregion
    }
}