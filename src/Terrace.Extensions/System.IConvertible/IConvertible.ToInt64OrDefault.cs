using System;
using System.Globalization;
using System.Linq;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static long ToInt64OrDefault(this IConvertible @this)
        {
            return @this.ToInt64OrDefault(default);
        }

        public static long ToInt64OrDefault(this IConvertible @this, long defaultValue)
        {
            try
            {
                return @this.ToInt64(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
