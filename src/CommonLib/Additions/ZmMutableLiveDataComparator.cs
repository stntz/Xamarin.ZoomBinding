using System;
using System.Collections.Generic;
using System.Text;
using Object = Java.Lang.Object;

// ReSharper disable once CheckNamespace the namespace needs to match the defined partial class
namespace US.Zoom.Androidlib.Mvvm.Data {

    public partial class ZmMutableLiveDataComparator
    {
        public int Compare(Object? o1, Object? o2)
        {
            return Compare((ZmMutableLiveData)o1, (ZmMutableLiveData)o2);
        }
    }

}
