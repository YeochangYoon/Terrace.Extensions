using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class BitArrayExtension
    {
        public static int[] ToInt32s(this BitArray @this)
        {
            int length = (@this.Length / 32) + (@this.Length % 32 == 0 ? 0 : 1);
            int[] array = new int[length];
            @this.CopyTo(array, 0);
            
            return array;
        }
    }
}
