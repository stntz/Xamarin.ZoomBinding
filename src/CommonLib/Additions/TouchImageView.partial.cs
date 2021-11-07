
// ReSharper disable once CheckNamespace this has to be this namespace
namespace US.Zoom.Androidlib.Widget
{
    public partial class TouchImageView
    {
        void ITouchViewControl.Left()
        {
            InvokeLeft();
        }

        void ITouchViewControl.Right()
        {
            InvokeRight();
        }

    }
}