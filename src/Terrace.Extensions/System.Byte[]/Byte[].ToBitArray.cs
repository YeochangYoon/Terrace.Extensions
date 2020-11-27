using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ByteArrayExtension
    {
        public static BitArray ToBitArray(this byte[] @this)
        {
            return new BitArray(@this);
        }

        public static BitArray ToBitArray(this byte[] @this, int bitIndex)
        {
            return new BitArray(@this).GetRange(bitIndex);
        }

        public static BitArray ToBitArray(this byte[] @this, int bitIndex, int bitCount)
        {
            return new BitArray(@this).GetRange(bitIndex, bitCount);
        }
    }
}
