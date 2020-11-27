using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static string ToUnicodeString(this byte[] @this)
        {
            return Encoding.Unicode.GetString(@this);
        }

        public static string ToUnicodeString(this byte[] @this, int index)
        {
            return Encoding.Unicode.GetString(@this, index, @this.Length - index);
        }

        public static string ToUnicodeString(this byte[] @this, int index, int count)
        {
            return Encoding.Unicode.GetString(@this, index, count);
        }
    }
}
