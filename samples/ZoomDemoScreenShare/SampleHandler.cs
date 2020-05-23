using System;

using Foundation;
using ReplayKit;

using ZoomiosScreenShare;

namespace ZoomDemoScreenShare
{
    // To handle samples with a subclass of RPBroadcastSampleHandler set the following in the extension's Info.plist file:
    // - RPBroadcastProcessMode should be set to RPBroadcastProcessModeSampleBuffer
    // - NSExtensionPrincipalClass should be set to this class
    public class SampleHandler : RPBroadcastSampleHandler
    {
        MobileRTCScreenShareService screenShareService;

        public SampleHandler()
        {
            MobileRTCScreenShareService service = new MobileRTCScreenShareService();
            screenShareService = service;
            screenShareService.AppGroup = "group.com.syndew.zoomdemo";
            screenShareService.Delegate = new ZoomDemoScreenShareDelegate();
            service.Dispose();
        }

        //MobileRTCScreenShareService screenShareService;
        protected SampleHandler(IntPtr handle) : base(handle)
        {            
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void BroadcastStarted(NSDictionary<NSString, NSObject> setupInfo)
        {
            // User has requested to start the broadcast. Setup info from the UI extension will be supplied.
            screenShareService.BroadcastStartedWithSetupInfo(setupInfo);
        }

        public override void BroadcastPaused()
        {
            // User has requested to pause the broadcast. Samples will stop being delivered.
            screenShareService.BroadcastPaused();
        }

        public override void BroadcastResumed()
        {
            // User has requested to resume the broadcast. Samples delivery will resume.
            screenShareService.BroadcastResumed();
        }

        public override void BroadcastFinished()
        {
            // User has requested to finish the broadcast.
            screenShareService.BroadcastFinished();
        }

        public override void ProcessSampleBuffer(CoreMedia.CMSampleBuffer sampleBuffer, RPSampleBufferType sampleBufferType)
        {
            screenShareService.ProcessSampleBuffer(sampleBuffer, sampleBufferType);            
        }

        internal class ZoomDemoScreenShareDelegate : MobileRTCScreenShareServiceDelegate
        {
            public override void MobileRTCScreenShareServiceFinishBroadcastWithError(NSError error)
            {
                
            }
        }        
    }
}
