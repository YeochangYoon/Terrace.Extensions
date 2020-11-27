using System;
using System.Globalization;
using System.Linq;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static int ToInt32OrDefault(this IConvertible @this)
        {
            return @this.ToInt32OrDefault(default);
        }

        public static int ToInt32OrDefault(this IConvertible @this, int defaultValue)
        {
            try
            {
                return @this.ToInt32(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
