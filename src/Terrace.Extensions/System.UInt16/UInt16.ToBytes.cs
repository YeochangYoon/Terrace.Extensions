using System;

namespace Terrace.Extensions
{
    public static partial class UInt16Extension
    {
        public static byte[] ToBytes(this ushort @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
