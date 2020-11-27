using System;

namespace Terrace.Extensions
{
    public static partial class ObjectExtension
    {
        public static void IsNotNullThen<T>(this T @this, Action action) where T : class
        {
            if (!(@this is null))
            {
                action();
            }
        }

        public static void IsNotNullThen<T>(this T @this, Action<T> action) where T : class
        {
            if (!(@this is null))
            {
                action(@this);
            }
        }
    }
}
