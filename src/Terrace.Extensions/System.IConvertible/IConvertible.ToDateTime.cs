using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static DateTime ToDateTime(this IConvertible @this)
        {
            return @this.ToDateTime(CultureInfo.CurrentCulture);
        }
    }
}
