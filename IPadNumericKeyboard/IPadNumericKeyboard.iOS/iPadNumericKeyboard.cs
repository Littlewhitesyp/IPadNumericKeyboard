using Foundation;
using System;
using System.Collections.Generic;
using CoreGraphics;
using ObjCRuntime;
using UIKit;
using Xamarin.Forms;

namespace IPadNumericKeyboard.iOS
{
    public partial class iPadNumericKeyboard : UIView
    {
        private UITextField textField;
        private List<UIButton> buttons;
        private Entry entry;

        public iPadNumericKeyboard(IntPtr handle) : base(handle)
        {

        }

        public void SetNativeControl(UITextField textField)
        {
            this.textField = textField;
        }

        public void SetElement(Entry entry)
        {
            this.entry = entry;
        }

        public static iPadNumericKeyboard Create()
        {
            var nimbsArray = NSBundle.MainBundle.LoadNib("iPadNumericKeyboard", null, null);
            return Runtime.GetNSObject<iPadNumericKeyboard>(nimbsArray.ValueAt(0));
        }

        public override void AwakeFromNib()
        {
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            buttons = new List<UIButton>
            {
                ZeroNumberButton,
                OneNumberButton,
                TwoNumberButton,
                ThreeNumberButton,
                FourNumberButton,
                FiveNumberButton,
                SixNumberButton,
                SevenNumberButton,
                EightNumberButton,
                NineNumberButton
            };

            var number = 0;

            foreach (var button in buttons)
            {
                button.BackgroundColor = UIColor.White;
                button.Layer.MasksToBounds = false;
                button.Layer.ShadowOffset = new CGSize(0, 0.7f);
                button.Layer.ShadowRadius = 0f;
                button.Layer.ShadowOpacity = 1f;
                button.Layer.CornerRadius = 5;
                button.Layer.ShadowColor = UIColor.DarkGray.CGColor;
                button.AdjustsImageWhenHighlighted = false;

                button.SetTitle(Convert.ToString(number++), UIControlState.Normal);

                button.TouchDown += (sender, args) =>
                {
                    button.BackgroundColor = UIColor.FromRGB(163, 174, 194);
                };

                button.TouchUpInside += (sender, args) =>
                {
                    entry.Text += button.TitleLabel.Text;
                    button.BackgroundColor = UIColor.White;
                };

                button.TouchUpOutside += (sender, args) =>
                {
                    button.BackgroundColor = UIColor.White;
                };
            }
        }

        partial void DeleteNumberButton_TouchUpInside(UIButton sender)
        {
            if (entry.Text.Length > 0)
            {
                entry.Text = entry.Text.Remove(entry.Text.Length - 1);
            }
        }

        partial void CloseKeyboardButton_TouchUpInside(UIButton sender)
        {
            textField.ResignFirstResponder();
        }
    }
}