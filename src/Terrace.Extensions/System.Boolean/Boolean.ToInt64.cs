using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static long ToInt64(this bool @this)
        {
            return Convert.ToInt64(@this);
        }
    }
}
