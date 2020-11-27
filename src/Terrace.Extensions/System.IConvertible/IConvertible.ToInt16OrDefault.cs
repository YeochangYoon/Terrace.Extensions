using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static short ToInt16OrDefault(this IConvertible @this)
        {
            return @this.ToInt16OrDefault(default);
        }

        public static short ToInt16OrDefault(this IConvertible @this, short defaultValue)
        {
            try
            {
                return @this.ToInt16(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
