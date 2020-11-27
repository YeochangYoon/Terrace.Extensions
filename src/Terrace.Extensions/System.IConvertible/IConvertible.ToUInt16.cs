using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static ushort ToUInt16(this IConvertible @this)
        {
            return @this.ToUInt16(CultureInfo.CurrentCulture);
        }
    }
}
