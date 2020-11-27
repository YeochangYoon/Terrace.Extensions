using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static short ToInt16(this IConvertible @this)
        {
            return @this.ToInt16(CultureInfo.CurrentCulture);
        }
    }
}
