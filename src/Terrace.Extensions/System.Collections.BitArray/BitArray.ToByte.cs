using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class BitArrayExtension
    {
        public static byte ToByte(this BitArray @this)
        {
            if (@this.Length > 8)
            {
                throw new InvalidOperationException("BitArray length must be at most 8 bits.");
            }

            byte[] array = new byte[1];
            @this.CopyTo(array, 0);

            return array[0];
        }
    }
}
