using System;

namespace Terrace.Extensions
{
    public static partial class UInt64Extension
    {
        public static byte[] ToBytes(this ulong @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
