using System;
using System.Collections.Generic;

namespace US.Zoom.Androidlib.Util
{
    public partial class HashMapComparator
    {
        public virtual unsafe int Compare(Java.Lang.Object map1, Java.Lang.Object map2)
        {
            return Compare((IDictionary<string, object>)map1, (IDictionary<string, object>)map2);
        }
    }
}
