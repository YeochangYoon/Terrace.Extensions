using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static ushort ToUInt16(this byte[] @this, int startIndex = 0)
        {
            return BitConverter.ToUInt16(@this, startIndex);
        }
    }
}
