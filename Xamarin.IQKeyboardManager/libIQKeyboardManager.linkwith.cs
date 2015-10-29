using System;
using ObjCRuntime;
using Foundation;

[assembly: LinkWith (
	"libIQKeyboardManager.a", 
	LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64, 
//TODO: Why u dumb link only for devices?
//	SmartLink = true, 
	ForceLoad = true)]
[assembly: LinkerSafe ]
