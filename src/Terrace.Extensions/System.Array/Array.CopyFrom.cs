using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ArrayExtension
    {
        public static T[] CopyFrom<T>(this T[] @this, int index, T sourceArray)
        {
            return @this.CopyFrom(index, new T[] { sourceArray }, 0, 1);
        }

        public static T[] CopyFrom<T>(this T[] @this, int index, T[] sourceArray)
        {
            return @this.CopyFrom(index, sourceArray, 0, sourceArray.Length);
        }

        public static T[] CopyFrom<T>(this T[] @this, int index, T[] sourceArray, int sourceIndex)
        {
            return @this.CopyFrom(index, sourceArray, sourceIndex, sourceArray.Length - sourceIndex);
        }

        public static T[] CopyFrom<T>(this T[] @this, int index, T[] sourceArray, int sourceIndex, int count)
        {
            Array.Copy(sourceArray, sourceIndex, @this, index, count);
            return @this;
        }

        public static T[] CopyFrom<T>(this T[] @this, ref int index, T sourceArray)
        {
            return @this.CopyFrom(ref index, new T[] { sourceArray }, 0, 1);
        }

        public static T[] CopyFrom<T>(this T[] @this, ref int index, T[] sourceArray)
        {
            return @this.CopyFrom(ref index, sourceArray, 0, sourceArray.Length);
        }

        public static T[] CopyFrom<T>(this T[] @this, ref int index, T[] sourceArray, int sourceIndex)
        {
            return @this.CopyFrom(ref index, sourceArray, sourceIndex, sourceArray.Length - sourceIndex);
        }

        public static T[] CopyFrom<T>(this T[] @this, ref int index, T[] sourceArray, int sourceIndex, int count)
        {
            Array.Copy(sourceArray, sourceIndex, @this, index, count);
            index += count;

            return @this;
        }
    }
}
