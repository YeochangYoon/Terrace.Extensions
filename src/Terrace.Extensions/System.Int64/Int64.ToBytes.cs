using System;

namespace Terrace.Extensions
{
    public static partial class Int64Extension
    {
        public static byte[] ToBytes(this long @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
