using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static uint ToUInt32(this bool @this)
        {
            return Convert.ToUInt32(@this);
        }
    }
}
