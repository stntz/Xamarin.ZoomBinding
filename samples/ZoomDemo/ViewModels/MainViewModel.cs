using System;
using System.Windows.Input;
using Xamarin.Forms;
using ZoomDemo.Helpers;
using ZoomDemo.Interfaces;

namespace ZoomDemo.ViewModels
{
    public class MainViewModel
    {
        IZoomService zoomService;
        public MainViewModel()
        {
            zoomService = DependencyService.Get<IZoomService>();
            zoomService.InitZoomLib(Constants.AppKey, Constants.AppSecret);
            JoinMeetingCommand = new Command(JoinAction);
            EndMeetingCommand = new Command(EndMeetingAction);
        }

        public string MeetingID { get; set; }
        public string MeetingPassword { get; set; }
        public string DisplayName { get; set; }
        public ICommand JoinMeetingCommand { get; }
        public ICommand EndMeetingCommand { get; }

        void JoinAction()
        {
            if (!zoomService.IsInitialized())
            {
                return;
            }

            zoomService.JoinMeeting(MeetingID, MeetingPassword, DisplayName);
        }

        void EndMeetingAction()
        {
            zoomService.LeaveMeeting();
        }
    }
}