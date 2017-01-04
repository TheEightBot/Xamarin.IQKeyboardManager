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
        UIKit.UIButton btnGetControlType { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField sampleText { get; set; }

        [Action ("BtnGetControlType_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnGetControlType_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnGetControlType != null) {
                btnGetControlType.Dispose ();
                btnGetControlType = null;
            }

            if (sampleText != null) {
                sampleText.Dispose ();
                sampleText = null;
            }
        }
    }
}