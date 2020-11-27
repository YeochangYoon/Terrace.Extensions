using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static byte ToByteOrDefault(this IConvertible @this)
        {
            return @this.ToByteOrDefault(default);
        }

        public static byte ToByteOrDefault(this IConvertible @this, byte defaultValue)
        {
            try
            {
                return @this.ToByte(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
