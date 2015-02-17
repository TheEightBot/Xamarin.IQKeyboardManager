using System;
using ObjCRuntime;

[assembly: LinkWith (
	"libIQKeyboardManager.a", 
	LinkTarget.ArmV7 | LinkTarget.Arm64 | LinkTarget.ArmV7s | LinkTarget.Simulator | LinkTarget.Simulator64, 
	SmartLink = true, 
	ForceLoad = true)]
