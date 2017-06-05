// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace LearningViewController
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel hhah { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView welcomeLabel { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (hhah != null) {
                hhah.Dispose ();
                hhah = null;
            }

            if (welcomeLabel != null) {
                welcomeLabel.Dispose ();
                welcomeLabel = null;
            }
        }
    }
}