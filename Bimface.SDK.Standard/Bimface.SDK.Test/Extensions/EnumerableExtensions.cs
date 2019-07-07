using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bimface.SDK.Test.Extensions
{
    public static class EnumerableExtensions
    {
        public static T GetRandom<T>(this IEnumerable<T> enumerable)
        {
            var array  = enumerable as T[] ?? enumerable.ToArray();
            var random = new Random(DateTime.Now.Millisecond).Next(0, array.Length);
            return array.ElementAtOrDefault(random);
        }
    }
}
