using System;

namespace Terrace.Extensions
{
    public static partial class Int16Extension
    {
        public static byte[] ToBytes(this short @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
