using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static ushort ToUInt16(this bool @this)
        {
            return Convert.ToUInt16(@this);
        }
    }
}
