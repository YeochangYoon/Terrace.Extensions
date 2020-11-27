using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static sbyte ToSByte(this IConvertible @this)
        {
            return @this.ToSByte(CultureInfo.CurrentCulture);
        }
    }
}
