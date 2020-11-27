using System;

namespace Terrace.Extensions
{
    public static partial class ObjectExtension
    {
        public static void IsNullThen<T>(this T @this, Action action) where T : class
        {
            if (@this is null)
            {
                action();
            }
        }
    }
}
