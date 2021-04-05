using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static decimal ToDecimal(this bool @this)
        {
            return Convert.ToDecimal(@this);
        }
    }
}
