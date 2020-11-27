using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static ushort ToUInt16OrDefault(this IConvertible @this)
        {
            return @this.ToUInt16OrDefault(default);
        }

        public static ushort ToUInt16OrDefault(this IConvertible @this, ushort defaultValue)
        {
            try
            {
                return @this.ToUInt16(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
