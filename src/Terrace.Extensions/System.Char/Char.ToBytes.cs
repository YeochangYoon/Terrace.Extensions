using System;

namespace Terrace.Extensions
{
    public static partial class CharExtension
    {
        public static byte[] ToBytes(this char @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
