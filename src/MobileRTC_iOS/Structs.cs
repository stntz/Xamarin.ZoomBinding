using ObjCRuntime;

namespace Zoomios
{
	public enum MobileRTCAuthError : uint
	{
		Success,
		KeyOrSecretEmpty,
		KeyOrSecretWrong,
		AccountNotSupport,
		AccountNotEnableSDK,
		Unknown
	}

	public enum MobileRTCMeetError : uint
	{
		Success = 0,
		NetworkError = 1,
		ReconnectError = 2,
		MMRError = 3,
		PasswordError = 4,
		SessionError = 5,
		MeetingOver = 6,
		MeetingNotStart = 7,
		MeetingNotExist = 8,
		MeetingUserFull = 9,
		MeetingClientIncompatible = 10,
		NoMMR = 11,
		MeetingLocked = 12,
		MeetingRestricted = 13,
		MeetingRestrictedJBH = 14,
		CannotEmitWebRequest = 15,
		CannotStartTokenExpire = 16,
		VideoError = 17,
		AudioAutoStartError = 18,
		RegisterWebinarFull = 19,
		RegisterWebinarHostRegister = 20,
		RegisterWebinarPanelistRegister = 21,
		RegisterWebinarDeniedEmail = 22,
		RegisterWebinarEnforceLogin = 23,
		ZCCertificateChanged = 24,
		VanityNotExist = 27,
		JoinWebinarWithSameEmail = 28,
		WriteConfigFile = 50,
		RemovedByHost = 61,
		InvalidArguments = WriteConfigFile + 100,
		InvalidUserType,
		InAnotherMeeting,
		VBBase = 200,
		VBSetError = VBBase,
		VBMaximumNum,
		VBSaveImage,
		VBRemoveNone,
		VBNoSupport,
		Unknown
	}

	public enum MobileRTCMeetingState : uint
	{
		Idle = 0,
		Connecting = 1,
		InMeeting = 2,
		WebinarPromote = 3,
		WebinarDePromote = 4
	}

	public enum MobileRTCUserType : uint
	{
		Facebook = 0,
		GoogleOAuth = 2,
		DeviceUser = 97,
		APIUser = 99,
		ZoomUser = 100,
		SSOUser = 101,
		Unknown = 102
	}

	public enum LeaveMeetingCmd : uint
	{
		Leave,
		End
	}

	public enum JBHCmd : uint
	{
		Show,
		Hide
	}

	public enum DialOutStatus : uint
	{
		Unknown = 0,
		Calling,
		Ringing,
		Accepted,
		Busy,
		NotAvailable,
		UserHangUp,
		OtherFail,
		JoinSuccess,
		TimeOut,
		ZoomStartCancelCall,
		ZoomCallCanceled,
		ZoomCancelCallFail,
		NoAnswer,
		BlockNoHost,
		BlockHighRate,
		BlockTooFrequent
	}

	public enum H323CallOutStatus : uint
	{
		Ok = 0,
		Calling,
		Busy,
		Failed
	}

	[Native]
	public enum MobileRTCH323ParingStatus : ulong
	{
		Success = 0,
		MeetingNotExisted,
		PermissionDenied,
		ParingcodeNotExisted,
		Error
	}

	public enum MobileRTCComponentType : uint
	{
		Def = 0,
		Chat,
		Ft,
		Audio,
		Video,
		As
	}

	public enum MobileRTCNetworkQuality
	{
		Unknown = -1,
		VeryBad = 0,
		Bad = 1,
		NotGood = 2,
		Normal = 3,
		Good = 4,
		Excellent = 5
	}

	public enum MobileRTCAudioError : uint
	{
		Success = 0,
		AudioPermissionDenied = 1,
		AudioNotConnected = 2,
		CannotUnmuteMyAudio = 3
	}

	public enum MobileRTCVideoError : uint
	{
		Success = 0,
		CameraPermissionDenied = 1,
		CannotUnmuteMyVideo = 3
	}

	public enum MobileRTCCameraError : uint
	{
		Success = 0,
		CameraPermissionDenied = 1,
		VideoNotSending = 2
	}

	public enum MobileRTCLiveStreamStatus : uint
	{
		Successed = 0,
		FailedOrEnded = 1,
		Timeout = 2
	}

	public enum MobileRTCClaimHostError : uint
	{
		Successed = 0,
		HostKeyError = 1,
		NetWorkError = 2
	}

	public enum MobileRTCSendChatError : uint
	{
		Successed = 0,
		Failed = 1,
		PermissionDenied = 2
	}

	public enum MobileRTCAnnotationError : uint
	{
		Successed = 0,
		Failed = 1,
		PermissionDenied = 2
	}

	public enum MobileRTCCMRError : uint
	{
		Successed = 0,
		Failed = 1,
		StorageFull = 2
	}

	public enum MobileRTCJoinMeetingInfo : uint
	{
		NeedName = 0,
		NeedPassword = 1,
		WrongPassword = 2,
		NeedNameAndPwd = 3
	}

	public enum MobileRTCMicrophoneError : uint
	{
		MicMuted = 0,
		FeedbackDetected = 1,
		MicUnavailable = 2
	}

	public enum MobileRTCMeetingEndReason : uint
	{
		SelfLeave = 0,
		RemovedByHost = 1,
		EndByHost = 2,
		JBHTimeout = 3,
		FreeMeetingTimeout = 4,
		HostEndForAnotherMeeting = 6,
		ConnectBroken = 7,
		Unknown
	}

	public enum MobileRTCRemoteControlError : uint
	{
		Successed = 0,
		Stop = 1,
		Failed = 2,
		PermissionDenied = 3
	}

	[Native]
	public enum MobileRTCAudioOutput : ulong
	{
		Unknown = 0,
		Receiver = 1,
		Speaker = 2,
		Headphones = 3,
		Bluetooth = 4
	}

	[Native]
	public enum MobileRTCChatAllowAttendeeChat : ulong
	{
		None = 1,
		All = 2,
		Panelist = 3
	}

	[Native]
	public enum MobileRTCWebinarPromoteorDepromoteError : ulong
	{
		Success = 0,
		Webinar_Panelist_Capacity_Exceed = 3035,
		Not_Found_Webinar_Attendee = 3029
	}

	[Native]
	public enum MobileRTCMeetingItemAudioType : ulong
	{
		Unknown = 0,
		TelephoneOnly = 1,
		VoipOnly = 2,
		TelephoneAndVoip = 3,
		MobileRTCMeetingItemAudioType_3rdPartyAudio = 4
	}

	[Native]
	public enum MobileRTCMeetingItemRecordType : ulong
	{
		AutoRecordDisabled = 0,
		LocalRecord = 1,
		CloudRecord = 2
	}

	[Native]
	public enum MobileRTCMeetingChatPriviledgeType : ulong
	{
		Unknown = 0,
		Everyone_Publicly_And_Privately,
		Host_Only,
		No_One,
		Everyone_Publicly
	}

	[Native]
	public enum MobileRTCVideoType : ulong
	{
		VideoData = 1,
		ShareData
	}

	[Native]
	public enum MobileRTCVideoResolution : ulong
	{
		MobileRTCVideoResolution_90,
		MobileRTCVideoResolution_180,
		MobileRTCVideoResolution_360,
		MobileRTCVideoResolution_720
	}

	[Native]
	public enum MobileRTCVideoRawDataFormat : ulong
	{
		MobileRTCVideoRawDataFormatI420 = 1,
		Limit
	}

	[Native]
	public enum MobileRTCVideoRawDataRotation : long
	{
		None = 1,
		MobileRTCVideoRawDataRotation90,
		MobileRTCVideoRawDataRotation180,
		MobileRTCVideoRawDataRotation270
	}

	[Native]
	public enum MobileRTCRawDataError : ulong
	{
		Success,
		Uninitialized,
		Malloc_Failed,
		Wrongusage,
		Invalid_Param,
		Not_In_Meeting,
		No_License,
		Video_Module_Not_Ready,
		Video_Module_Error,
		Video_device_error,
		No_Video_Data,
		Share_Module_Not_Ready,
		Hare_Module_Error,
		No_Share_Data,
		Audio_Module_Not_Ready,
		Audio_Module_Error,
		No_Audio_Data
	}

	[Native]
	public enum MobileRTCRawDataMemoryMode : ulong
	{
		Stack,
		Heap
	}

	[Native]
	public enum MobileRTC_ZoomLocale : ulong
	{
		Default,
		Cn
	}

	[Native]
	public enum MobileRTCSMSServiceErr : ulong
	{
		Unknown,
		Success,
		Retrieve_SendSMSFailed,
		Retrieve_InvalidPhoneNum,
		Retrieve_PhoneNumAlreadyBound,
		Retrieve_PhoneNumSendTooFrequent,
		Verify_CodeIncorrect,
		Verify_CodeExpired,
		Verify_UnknownError
	}

	[Native]
	public enum MobileRTCMinimizeMeetingState : ulong
	{
		ShowMinimizeMeeting,
		BackFullScreenMeeting
	}

	[Native]
	public enum MobileRTCBOUserStatus : ulong
	{
		Unassigned = 1,
		NotJoin = 2,
		InBO = 3
	}

	public enum MobileRTCAudioType : uint
	{
		VoIP = 0,
		Telephony,
		None
	}

	public enum MobileRTCFeedbackType : uint
	{
		None = 0,
		Hand,
		Yes,
		No,
		Fast,
		Slow,
		Good,
		Bad,
		Clap,
		Coffee,
		Clock,
		Emoji
	}

	public enum MobileRTCDeviceType : uint
	{
		H323 = 1,
		Sip,
		Both
	}

	public enum MobileRTCDeviceEncryptType : uint
	{
		None = 0,
		Encrypt,
		Auto
	}

	public enum MobileRTCChatGroup : uint
	{
		All = 0,
		Panelists = 1
	}

	[Native]
	public enum AudioOptionType : ulong
	{
		TelephonyOnly,
		VoipOnly,
		VoipAndTelephony,
		ThirdPartyAudio
	}

	public enum MeetingRepeat : uint
	{
		None = 0,
		EveryDay,
		EveryWeek,
		Every2Weeks,
		EveryMonth,
		EveryYear
	}

	public enum PreMeetingError
	{
		Unknown = -1,
		Success = 0,
		ErrorDomain = 1,
		ErrorService = 2,
		ErrorInputValidation = 300,
		ErrorHttpResponse = 404,
		ErrorNoMeetingNumber = 3009,
		ErrorTimeOut = 5003
	}

	public enum MobileRTCVideoAspect : uint
	{
		Original = 0,
		Full_Filled = 1,
		LetterBox = 2,
		PanAndScan = 3
	}

	public enum MobileRTCAnnoTool : uint
	{
		Whiteboard = 1,
		Spotlight = 2,
		Pen = 3,
		Highligher = 4,
		Line = 8,
		Arrow = 9,
		Arrow2 = 10,
		Rectangle = 11,
		Ellipse = 12,
		Text = 13,
		Eraser = 15
	}

	public enum MobileRTCRemoteControlInputType : uint
	{
		Del,
		Return
	}

}