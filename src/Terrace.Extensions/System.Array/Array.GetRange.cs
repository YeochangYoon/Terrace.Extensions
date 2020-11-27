using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ArrayExtension
    {
        public static T[] GetRange<T>(this T[] @this, int index)
        {
            return @this.GetRange(index, @this.Length - index);
        }

        public static T[] GetRange<T>(this T[] @this, int index, int count)
        {
            T[] rnage = new T[count];
            Array.Copy(@this, index, rnage, 0, count);
            
            return rnage;
        }
    }
}
