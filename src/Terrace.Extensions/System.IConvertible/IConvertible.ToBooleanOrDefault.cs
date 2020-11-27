using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static bool ToBooleanOrDefault(this IConvertible @this)
        {
            return @this.ToBooleanOrDefault(default);
        }

        public static bool ToBooleanOrDefault(this IConvertible @this, bool defaultValue)
        {
            try
            {
                return @this.ToBoolean(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
