using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class BitArrayExtension
    {
        public static BitArray GetRange(this BitArray @this, int index)
        {
            return @this.GetRange(index, @this.Length - index);
        }

        public static BitArray GetRange(this BitArray @this, int index, int count)
        {
            BitArray range = new BitArray(count);
            for (int i = 0; i < count; i++)
            {
                range[i] = @this[index + i];
            }

            return range;
        }
    }
}
