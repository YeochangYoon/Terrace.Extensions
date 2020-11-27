using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static decimal ToDecimal(this IConvertible @this)
        {
            return @this.ToDecimal(CultureInfo.CurrentCulture);
        }
    }
}
