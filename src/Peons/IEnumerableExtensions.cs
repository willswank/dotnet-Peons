using System.Collections.Generic;
using System.Linq;

namespace Peons
{
    public static class IEnumerableExtensions
    {
        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || enumerable.IsEmpty();
        }

        public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
        {
            return !enumerable.Any();
        }
    }
}
