using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static byte ToByte(this bool @this)
        {
            return Convert.ToByte(@this);
        }
    }
}
