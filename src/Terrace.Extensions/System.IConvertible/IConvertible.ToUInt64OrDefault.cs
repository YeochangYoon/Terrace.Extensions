using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static ulong ToUInt64OrDefault(this IConvertible @this)
        {
            return @this.ToUInt64OrDefault(default);
        }

        public static ulong ToUInt64OrDefault(this IConvertible @this, ulong defaultValue)
        {
            try
            {
                return @this.ToUInt64(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
