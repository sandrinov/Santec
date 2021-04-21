using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SantecExtensions
{
    public static class IEnumerableExtensions
    {
        public static bool HasMoreThanThreeElements<T>(this IEnumerable<T> enumerable)
        {
            return enumerable.Count() > 3;
        }
    }
}
