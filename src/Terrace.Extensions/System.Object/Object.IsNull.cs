using System;

namespace Terrace.Extensions
{
    public static partial class ObjectExtension
    {
        public static bool IsNull<T>(this T @this) where T : class
        {
            return @this is null;
        }
    }
}
