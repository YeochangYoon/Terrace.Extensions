using System;

namespace Terrace.Extensions
{
    public static partial class Int32Extension
    {
        public static byte[] ToBytes(this int @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
