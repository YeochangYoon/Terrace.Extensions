using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static double ToDoubleOrDefault(this IConvertible @this)
        {
            return @this.ToDoubleOrDefault(default);
        }

        public static double ToDoubleOrDefault(this IConvertible @this, double defaultValue)
        {
            try
            {
                return @this.ToDouble(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
