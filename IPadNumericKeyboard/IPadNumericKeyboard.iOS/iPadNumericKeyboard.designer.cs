// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace IPadNumericKeyboard.iOS
{
    [Register ("iPadNumericKeyboard")]
    partial class iPadNumericKeyboard
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView ButtonsCanvas { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton CloseKeyboardButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton DeleteNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EightNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FiveNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton FourNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton NineNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton OneNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SevenNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton SixNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ThreeNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton TwoNumberButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ZeroNumberButton { get; set; }

        [Action ("CloseKeyboardButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void CloseKeyboardButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("DeleteNumberButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DeleteNumberButton_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ButtonsCanvas != null) {
                ButtonsCanvas.Dispose ();
                ButtonsCanvas = null;
            }

            if (CloseKeyboardButton != null) {
                CloseKeyboardButton.Dispose ();
                CloseKeyboardButton = null;
            }

            if (DeleteNumberButton != null) {
                DeleteNumberButton.Dispose ();
                DeleteNumberButton = null;
            }

            if (EightNumberButton != null) {
                EightNumberButton.Dispose ();
                EightNumberButton = null;
            }

            if (FiveNumberButton != null) {
                FiveNumberButton.Dispose ();
                FiveNumberButton = null;
            }

            if (FourNumberButton != null) {
                FourNumberButton.Dispose ();
                FourNumberButton = null;
            }

            if (NineNumberButton != null) {
                NineNumberButton.Dispose ();
                NineNumberButton = null;
            }

            if (OneNumberButton != null) {
                OneNumberButton.Dispose ();
                OneNumberButton = null;
            }

            if (SevenNumberButton != null) {
                SevenNumberButton.Dispose ();
                SevenNumberButton = null;
            }

            if (SixNumberButton != null) {
                SixNumberButton.Dispose ();
                SixNumberButton = null;
            }

            if (ThreeNumberButton != null) {
                ThreeNumberButton.Dispose ();
                ThreeNumberButton = null;
            }

            if (TwoNumberButton != null) {
                TwoNumberButton.Dispose ();
                TwoNumberButton = null;
            }

            if (ZeroNumberButton != null) {
                ZeroNumberButton.Dispose ();
                ZeroNumberButton = null;
            }
        }
    }
}