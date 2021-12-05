using System;
using System.Collections.Generic;
using System.Linq;

namespace NoodleTemplate
{
    public static class Misc
    {
        public static IEnumerable<object> CloneArray(this IEnumerable<object> Array)
        {
            return Array.Select(item =>
            {
                if (item is IEnumerable<object> nestedArray) return nestedArray.CloneArray();
                else if (item is ICloneable cloneable) return cloneable.Clone();
                else return item;
            });
        }
        public static IEnumerable<T> CombineWith<T>(this IEnumerable<T> first, params IEnumerable<T>[] arrays)
        {
            List<T> list = new List<T>();
            list.AddRange(first);
            foreach (var array in arrays) if (array != null) list.AddRange(array);

            return list.ToArray();
        }
        public static IList<object> Array(params object[] Objects) => Objects.ToList();

        public static void d(Func<string> m) => m();
    }
}
