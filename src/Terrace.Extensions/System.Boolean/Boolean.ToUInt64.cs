using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static ulong ToUInt64(this bool @this)
        {
            return Convert.ToUInt64(@this);
        }
    }
}
