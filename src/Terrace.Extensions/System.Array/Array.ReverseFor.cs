using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class ArrayExtension
    {
        public static T[] ReverseFor<T>(this T[] @this, Action<T, int> action)
        {
            for (int i = @this.Length - 1; i >= 0; i--)
            {
                action(@this[i], i);
            }

            return @this;
        }
    }
}
