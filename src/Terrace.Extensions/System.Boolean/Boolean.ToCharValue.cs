using System;

namespace Terrace.Extensions
{
    public static partial class BooleanExtension
    {
        public static char ToCharValue(this bool @this)
        {
            return @this ? (char)1 : (char)0;
        }
    }
}
