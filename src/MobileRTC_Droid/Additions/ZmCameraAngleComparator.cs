using System;
namespace Com.Zipow.Nydus.Camera
{
    public partial class ZmCameraAngleComparator
    {
        public virtual unsafe int Compare(Java.Lang.Object p0, Java.Lang.Object p1)
        {
            return Compare((Com.Zipow.Nydus.Camera.ZMCameraCharacteristic)p0, (Com.Zipow.Nydus.Camera.ZMCameraCharacteristic)p1);
        }
    }
}

