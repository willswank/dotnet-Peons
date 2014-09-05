using System;

namespace Peons
{
    public static class ObjectExtensions
    {
        public static bool Has<T>(this T input, Func<T, object> selector) where T : class
        {
            return selector(input) != null;
        }
    }
}
