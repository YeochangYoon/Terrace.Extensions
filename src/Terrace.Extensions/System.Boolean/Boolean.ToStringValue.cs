using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static string ToStringValue(this bool @this)
        {
            return @this ? "1" : "0";
        }
    }
}
