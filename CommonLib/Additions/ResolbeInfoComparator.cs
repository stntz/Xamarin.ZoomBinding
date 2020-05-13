using System;

namespace US.Zoom.Androidlib.Util
{
    public partial class AndroidAppUtil
    {
        public partial class ResolbeInfoComparator
        {
            public virtual unsafe int Compare(Java.Lang.Object lhs, Java.Lang.Object rhs)
            {
                return Compare((Android.Content.PM.ResolveInfo)lhs, (Android.Content.PM.ResolveInfo)rhs);
            }
        }
    }
}