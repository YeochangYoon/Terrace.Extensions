using System;
using System.Globalization;
using System.Linq;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static ulong ToUInt64(this IConvertible @this)
        {
            return @this.ToUInt64(CultureInfo.CurrentCulture);
        }
    }
}
