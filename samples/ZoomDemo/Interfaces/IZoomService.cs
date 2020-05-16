using System;
namespace ZoomDemo.Interfaces
{
    public interface IZoomService
    {
        bool IsInitialized();

        //Call this before other methods to Init the library
        void InitZoomLib(string appKey, string appSecret);

        void JoinMeeting(string meetingID, string meetingPassword, string displayName = "Zoom Demo");
        void LeaveMeeting(bool endMeeting = false);
    }
}
