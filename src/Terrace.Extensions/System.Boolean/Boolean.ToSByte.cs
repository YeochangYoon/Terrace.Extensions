using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static sbyte ToSByte(this bool @this)
        {
            return Convert.ToSByte(@this);
        }
    }
}
