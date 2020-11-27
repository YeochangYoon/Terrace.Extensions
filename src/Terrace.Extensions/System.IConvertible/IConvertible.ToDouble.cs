using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static double ToDouble(this IConvertible @this)
        {
            return @this.ToDouble(CultureInfo.CurrentCulture);
        }
    }
}
