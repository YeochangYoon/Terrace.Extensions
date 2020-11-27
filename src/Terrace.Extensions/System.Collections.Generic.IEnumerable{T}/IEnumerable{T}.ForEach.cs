using System;
using System.Collections.Generic;
using System.Text;

namespace Terrace.Extensions
{
    public static partial class IEnumerable_T_Extension
    {
        public static IEnumerable<T> ForEach<T>(this IEnumerable<T> @this, Action<T> action)
        {
            foreach (T element in @this)
            {
                action(element);
            }

            return @this;
        }
    }
}
