using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static bool ToBoolean(this IConvertible @this)
        {
            return @this.ToBoolean(CultureInfo.CurrentCulture);
        }
    }
}
