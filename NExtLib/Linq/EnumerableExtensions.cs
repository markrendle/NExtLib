using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NExtLib.Linq
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<Tuple<T, int>> WithIndex<T>(this IEnumerable<T> source)
        {
            int index = 0;
            return source.Select(item => Tuple.Create(item, index++));
        }
    }
}
