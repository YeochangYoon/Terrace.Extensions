using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static char ToCharOrDefault(this IConvertible @this)
        {
            return @this.ToCharOrDefault(default);
        }

        public static char ToCharOrDefault(this IConvertible @this, char defaultValue)
        {
            try
            {
                return @this.ToChar(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
