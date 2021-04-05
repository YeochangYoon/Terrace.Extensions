using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static char ToChar(this bool @this)
        {
            return @this ? '1' : '0';
        }
    }
}
