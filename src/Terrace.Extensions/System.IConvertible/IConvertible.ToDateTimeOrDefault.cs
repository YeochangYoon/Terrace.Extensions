using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static DateTime ToDateTimeOrDefault(this IConvertible @this)
        {
            return @this.ToDateTimeOrDefault(default);
        }

        public static DateTime ToDateTimeOrDefault(this IConvertible @this, DateTime defaultValue)
        {
            try
            {
                return @this.ToDateTime(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
