#region

using System.Reflection;

#endregion

namespace Bimface.SDK.Extensions
{
    public static class PropertyInfoExtensions
    {
        #region Others

        public static object GetPropertyValue(this PropertyInfo property, object obj)
        {
#if NET40
            return property.GetValue(obj, null);
#else
            return property.GetValue(obj);
#endif
        }

        #endregion
    }
}