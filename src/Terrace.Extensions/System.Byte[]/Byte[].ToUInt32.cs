using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static uint ToUInt32(this byte[] @this, int startIndex = 0)
        {
            return BitConverter.ToUInt32(@this, startIndex);
        }
    }
}
