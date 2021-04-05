using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static double ToDouble(this bool @this)
        {
            return Convert.ToDouble(@this);
        }
    }
}
