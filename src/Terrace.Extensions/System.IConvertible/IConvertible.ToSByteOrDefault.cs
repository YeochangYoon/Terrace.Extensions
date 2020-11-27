using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static sbyte ToSByteOrDefault(this IConvertible @this)
        {
            return @this.ToSByteOrDefault(default);
        }

        public static sbyte ToSByteOrDefault(this IConvertible @this, sbyte defaultValue)
        {
            try
            {
                return @this.ToSByte(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
