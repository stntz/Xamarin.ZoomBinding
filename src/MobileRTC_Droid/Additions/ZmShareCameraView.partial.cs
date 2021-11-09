using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using US.Zoom.Androidlib.Widget;

namespace Com.Zipow.Videobox.Confapp.Meeting.Scene.Sharecamera
{
    public partial class ZmShareCameraView
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