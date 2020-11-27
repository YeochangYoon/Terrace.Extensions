using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class BitArrayExtension
    {
        public static int ToInt32(this BitArray @this)
        {
            if (@this.Length > 32)
            {
                throw new InvalidOperationException("BitArray length must be at most 32 bits.");
            }

            int[] array = new int[1];
            @this.CopyTo(array, 0);
            
            return array[0];
        }
    }
}
