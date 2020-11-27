using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static string ToUTF8String(this byte[] @this)
        {
            return Encoding.UTF8.GetString(@this);
        }

        public static string ToUTF8String(this byte[] @this, int index)
        {
            return Encoding.UTF8.GetString(@this, index, @this.Length - index);
        }

        public static string ToUTF8String(this byte[] @this, int index, int count)
        {
            return Encoding.UTF8.GetString(@this, index, count);
        }
    }
}
