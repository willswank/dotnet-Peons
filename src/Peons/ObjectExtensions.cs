using System;

namespace Peons
{
    public static class ObjectExtensions
    {
        public static bool Exists(this object input)
        {
            return input != null;
        }
    }
}
