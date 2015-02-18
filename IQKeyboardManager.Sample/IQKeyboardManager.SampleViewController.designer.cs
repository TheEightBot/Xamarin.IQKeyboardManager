// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IQKeyboardManager.Sample
{
	[Register ("IQKeyboardManager_SampleViewController")]
	partial class IQKeyboardManager_SampleViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField sampleText { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (sampleText != null) {
				sampleText.Dispose ();
				sampleText = null;
			}
		}
	}
}
