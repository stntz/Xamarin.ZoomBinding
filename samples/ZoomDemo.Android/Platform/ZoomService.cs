using System;
using Android.App;
using US.Zoom.Sdk;
using Xamarin.Forms;
using ZoomDemo.Droid.Platform;
using ZoomDemo.Interfaces;

[assembly: Dependency(typeof(ZoomService))]
namespace ZoomDemo.Droid.Platform
{
    public class ZoomService : Java.Lang.Object, IZoomService, IZoomSDKInitializeListener
    {
        ZoomSDK zoomSDK;

        public void InitZoomLib(string appKey, string appSecret)
        {
            zoomSDK = ZoomSDK.Instance;
            var zoomInitParams = new ZoomSDKInitParams
            {
                AppKey = appKey,
                AppSecret = appSecret
            };
            zoomSDK.Initialize(Android.App.Application.Context, this, zoomInitParams);           
        }

        public bool IsInitialized()
        {
            return zoomSDK?.IsInitialized ?? false;
        }

        public void JoinMeeting(string meetingID, string meetingPassword, string displayName = "Zoom Demo")
        {
            if (IsInitialized())
            {
                var meetingService = zoomSDK.MeetingService;
                meetingService.JoinMeetingWithParams(Android.App.Application.Context, new JoinMeetingParams
                {
                    MeetingNo = meetingID,
                    Password = meetingPassword,
                    DisplayName = displayName
                });
            }
        }

        public void LeaveMeeting(bool endMeeting = false)
        {
            if (IsInitialized())
            {
                var meetingService = zoomSDK.MeetingService;
                meetingService.LeaveCurrentMeeting(endMeeting);
            }
        }

        public void OnZoomAuthIdentityExpired()
        {
            Console.WriteLine($"Authentication Expired");
        }

        public void OnZoomSDKInitializeResult(int p0, int p1)
        {
            Console.WriteLine($"Authentication Status: {p0} - {p1}");
        }
    }
}