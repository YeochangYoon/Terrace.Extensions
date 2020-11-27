using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static char ToChar(this IConvertible @this)
        {
            return @this.ToChar(CultureInfo.CurrentCulture);
        }
    }
}
