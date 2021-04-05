using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static float ToSingle(this bool @this)
        {
            return Convert.ToSingle(@this);
        }
    }
}
