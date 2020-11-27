using System;
using System.Globalization;
using System.Linq;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static uint ToUInt32(this IConvertible @this)
        {
            return @this.ToUInt32(CultureInfo.CurrentCulture);
        }
    }
}
