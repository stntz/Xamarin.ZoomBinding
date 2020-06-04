using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using ZoomDemo.Helpers;
using ZoomDemo.Interfaces;

namespace ZoomDemo.ViewModels
{
    public class LoginViewModel
    {
        IZoomService zoomService;
        public LoginViewModel()
        {
            zoomService = DependencyService.Get<IZoomService>();
            if (!zoomService.IsInitialized())
                zoomService.InitZoomLib(Constants.AppKey, Constants.AppSecret);

            LoginWithEmailCommand = new Command(LoginWithEmailAction);
            ListMeetingCommand = new Command(ListMeetingAction);
        }

        public string Email { get; set; }
        public string Password { get; set; }

        public ObservableCollection<object> Meetings { get; set; } = new ObservableCollection<object>();

        public ICommand LoginWithEmailCommand { get; set; }
        public ICommand ListMeetingCommand { get; set; }

        void LoginWithEmailAction()
        {
            var success = zoomService.LoginToZoom(Email, Password);
            //if (success)
            //{
            //    ListMeetingAction();
            //}
        }

        async void ListMeetingAction()
        {
            try
            {
                var meetingResult = await zoomService.ListMeeting();
                if (meetingResult != null)
                {

                }
            }
            catch(Exception ex) {
                Console.WriteLine(ex);
            }
        }
    }
}
