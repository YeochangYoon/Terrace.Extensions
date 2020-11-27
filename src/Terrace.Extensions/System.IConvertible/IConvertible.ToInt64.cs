using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static long ToInt64(this IConvertible @this)
        {
            return @this.ToInt64(CultureInfo.CurrentCulture);
        }
    }
}
