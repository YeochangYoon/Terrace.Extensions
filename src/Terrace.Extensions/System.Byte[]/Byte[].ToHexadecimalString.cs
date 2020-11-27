using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static string ToHexadecimalString(this byte[] @this)
        {
            return BitConverter.ToString(@this);
        }

        public static string ToHexadecimalString(this byte[] @this, int startIndex)
        {
            return BitConverter.ToString(@this, startIndex);
        }

        public static string ToHexadecimalString(this byte[] @this, int startIndex, int length)
        {
            return BitConverter.ToString(@this, startIndex, length);
        }
    }
}
