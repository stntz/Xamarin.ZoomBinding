using System;
using System.Collections.Generic;
using System.Text;
using US.Zoom.Androidlib.Widget;

namespace Com.Zipow.Videobox.Conference.Viewgroup
{
    public abstract partial class ZmAbstractShareControlView
    {
        void ITouchViewControl.Left()
        {
            InvokeLeft();
        }

        void  ITouchViewControl.Right()
        {
            InvokeRight();
        }
    }
}
