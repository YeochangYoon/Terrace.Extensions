using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static string ToASCIIString(this byte[] @this)
        {
            return Encoding.ASCII.GetString(@this);
        }

        public static string ToASCIIString(this byte[] @this, int index)
        {
            return Encoding.ASCII.GetString(@this, index, @this.Length - index);
        }

        public static string ToASCIIString(this byte[] @this, int index, int count)
        {
            return Encoding.ASCII.GetString(@this, index, count);
        }
    }
}
