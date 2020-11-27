using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static uint ToUInt32OrDefault(this IConvertible @this)
        {
            return @this.ToUInt32OrDefault(default);
        }

        public static uint ToUInt32OrDefault(this IConvertible @this, uint defaultValue)
        {
            try
            {
                return @this.ToUInt32(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
