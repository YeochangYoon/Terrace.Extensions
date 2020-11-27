using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static byte[] ToBytes(this bool @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
