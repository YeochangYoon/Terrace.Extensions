using System;

namespace Terrace.Extensions
{
    public static partial class SingleExtension
    {
        public static byte[] ToBytes(this float @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
