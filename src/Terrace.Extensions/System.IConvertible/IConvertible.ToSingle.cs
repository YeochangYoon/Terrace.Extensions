using System;
using System.Globalization;

namespace Terrace.Extensions
{
    public static partial class IConvertibleExtension
    {
        public static float ToSingle(this IConvertible @this)
        {
            return @this.ToSingle(CultureInfo.CurrentCulture);
        }
    }
}
