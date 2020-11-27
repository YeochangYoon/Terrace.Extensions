using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static byte[] ApplyEndian(this byte[] @this)
        {
            return BitConverter.IsLittleEndian ? @this.Reverse().ToArray() : @this;
        }
    }
}
