using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static float ToSingleOrDefault(this IConvertible @this)
        {
            return @this.ToSingleOrDefault(default);
        }

        public static float ToSingleOrDefault(this IConvertible @this, float defaultValue)
        {
            try
            {
                return @this.ToSingle(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {
                return defaultValue;
            }
        }
    }
}
