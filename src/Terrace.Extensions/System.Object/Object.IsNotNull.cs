using System;

namespace Terrace.Extensions
{
    public static partial class ObjectExtension
    {
        public static bool IsNotNull<T>(this T @this) where T : class
        {
            return !(@this is null);
        }
    }
}
