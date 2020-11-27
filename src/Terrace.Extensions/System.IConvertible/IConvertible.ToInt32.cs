using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static int ToInt32(this IConvertible @this)
        {
            return @this.ToInt32(CultureInfo.CurrentCulture);
        }
    }
}
