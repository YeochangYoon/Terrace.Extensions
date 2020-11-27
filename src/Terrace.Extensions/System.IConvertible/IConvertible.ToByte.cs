using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static byte ToByte(this IConvertible @this)
        {
            return @this.ToByte(CultureInfo.CurrentCulture);
        }
    }
}
