using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static short ToInt16(this bool @this)
        {
            return Convert.ToInt16(@this);
        }
    }
}
