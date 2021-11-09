using Java.Lang;

namespace Com.Zipow.Nydus.Camera
{
    public partial class ZmCameraCharacteristicComparator
    {
        public int Compare(Object? o1, Object? o2)
        {
            return Compare((ZMCameraCharacteristic) o1, (ZMCameraCharacteristic) o2);
        }
    }

    public partial class ZmCameraAngleComparator
    {
        public int Compare(Object? o1, Object? o2)
        {
            return Compare((ZMCameraCharacteristic) o1, (ZMCameraCharacteristic) o2);
        }
    }
}