using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static decimal ToDecimalOrDefault(this IConvertible @this)
        {
            return @this.ToDecimalOrDefault(default);
        }

        public static decimal ToDecimalOrDefault(this IConvertible @this, decimal defaultValue)
        {
            try
            {
                return @this.ToDecimal(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
