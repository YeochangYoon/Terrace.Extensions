using System;

namespace Terrace.Extensions
{
    public static partial class DoubleExtension
    {
        public static byte[] ToBytes(this double @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
