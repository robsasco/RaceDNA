// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace RaceDNA
{
    [Register ("MainViewController")]
    partial class MainViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton addNewBoatButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView RaceDNAMainView { get; set; }

        [Action ("AddNewBoatButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void AddNewBoatButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (addNewBoatButton != null) {
                addNewBoatButton.Dispose ();
                addNewBoatButton = null;
            }

            if (RaceDNAMainView != null) {
                RaceDNAMainView.Dispose ();
                RaceDNAMainView = null;
            }
        }
    }
}