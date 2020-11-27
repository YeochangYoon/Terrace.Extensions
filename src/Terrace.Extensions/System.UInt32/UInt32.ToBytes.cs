using System;

namespace Terrace.Extensions
{
    public static partial class UInt32Extension
    {
        public static byte[] ToBytes(this uint @this)
        {
            return BitConverter.GetBytes(@this);
        }
    }
}
