using System;
using ObjCRuntime;
using Foundation;

[assembly: LinkWith (
	"libIQKeyboardManager.a", 
	LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.Simulator | LinkTarget.Simulator64, 
//TODO: Why u dumb link only for devices?
	SmartLink = false, 
	ForceLoad = false)]
[assembly: LinkerSafe ]
