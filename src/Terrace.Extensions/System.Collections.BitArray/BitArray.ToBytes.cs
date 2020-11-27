using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class BitArrayExtension
    {
        public static byte[] ToBytes(this BitArray @this)
        {
            int length = (@this.Length / 8) + (@this.Length % 8 == 0 ? 0 : 1);
            byte[] array = new byte[length];
            @this.CopyTo(array, 0);

            return array;
        }
    }
}
