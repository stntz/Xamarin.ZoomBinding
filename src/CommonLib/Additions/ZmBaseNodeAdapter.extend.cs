using Object = Java.Lang.Object;

// ReSharper disable once CheckNamespace
namespace US.Zoom.Androidlib.Widget.Recyclerview.Provider.Node
{
    public partial class ZMBaseNodeAdapter
    {
        protected override void Convert(Java.Lang.Object p0, Object p1)
        {
            Convert((ZMBaseRecyclerViewItemHolder)p0,p1);
        }
    }
}