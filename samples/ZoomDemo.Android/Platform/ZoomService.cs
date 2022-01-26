using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.App;
using Java.Lang;
using US.Zoom.Sdk;
using Xamarin.Forms;
using ZoomDemo.Droid.Platform;
using ZoomDemo.Interfaces;

[assembly: Dependency(typeof(ZoomService))]
namespace ZoomDemo.Droid.Platform
{
    public class ZoomService : Java.Lang.Object, IZoomService, IZoomSDKInitializeListener //, IPreMeetingServiceListener
    {
        US.Zoom.Sdk.ZoomSDK zoomSDK;
        static TaskCompletionSource<object> meetingListSource;
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
                meetingService. JoinMeetingWithParams(Android.App.Application.Context, new JoinMeetingParams
                {
                    MeetingNo = meetingID,
                    Password = meetingPassword,
                    DisplayName = displayName
                }, new JoinMeetingOptions {  });
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

        //public Task<object> ListMeeting()
        //{
        //    if (IsInitialized())
        //    {
        //        if (meetingListSource != null)
        //            return null;

        //        var preMeeting = zoomSDK.PreMeetingService;
        //        preMeeting.AddListener(this);
        //        meetingListSource = new TaskCompletionSource<object>();
        //        _ = preMeeting.ListMeeting();              

        //        return meetingListSource.Task;
        //    }
        //    return null;
        //}

        public bool LoginToZoom(string email, string password, bool rememberMe = true)
        {
            throw new NotImplementedException("LoginWithZoom seems to have been removed from the zoom sdk");
            //if (IsInitialized())
            //{
            //    var loginInt = zoomSDK.LoginWithZoom(email, password);
            //    return loginInt == 0;
            //}
            //return false;
        }

        public void OnDeleteMeeting(int p0)
        {
            throw new NotImplementedException();
        }

        public void OnListMeeting(int p0, IList<Long> p1)
        {
            if(p0 == 0)
            {
                meetingListSource.SetResult(p1);
            }
            else
            {
                meetingListSource.SetResult(null);
            }
            
        }

        public void OnScheduleMeeting(int p0, long p1)
        {
            throw new NotImplementedException();
        }

        public void OnUpdateMeeting(int p0, long p1)
        {
            throw new NotImplementedException();
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