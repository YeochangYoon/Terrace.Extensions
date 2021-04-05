using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static int ToInt32(this bool @this)
        {
            return Convert.ToInt32(@this);
        }
    }
}
