﻿// Code ported from Obj-C to C#
// Taken from https://github.com/Marxon13/M13Checkbox
using System;
using System.ComponentModel;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using CoreGraphics;
using System.Diagnostics;
using Messier16.Forms.Controls;
using Messier16.Forms.iOS.Controls;

[assembly: ExportRenderer(typeof(Checkbox), typeof(CheckboxRenderer))]
namespace Messier16.Forms.iOS.Controls
{
    /// <summary>
    /// The check box renderer for iOS.
    /// </summary>
    public class CheckboxRenderer : ViewRenderer<Checkbox, UICheckbox>
    {

        /// <summary>
        /// Handles the Element Changed event
        /// </summary>
        /// <param name="e">The e.</param>
        protected override void OnElementChanged(ElementChangedEventArgs<Checkbox> e)
        {

            base.OnElementChanged(e);

            if (Element == null)
                return;

            BackgroundColor = Element.BackgroundColor.ToUIColor();
            if (e.NewElement != null)
            {
                if (Control == null)
                {
                    var checkBox = new UICheckbox();
                    checkBox.CheckedChanged += (s, args) => Element.Checked = args.Checked;
                    SetNativeControl(checkBox);
                }
                Control.SetCheckState(e.NewElement.Checked 
                    ? CheckState.Checked : CheckState.Unchecked);
                Control.SetEnabled(e.NewElement.IsEnabled);
//                Control.Hidden = e.NewElement.IsVisible;
            }

            //            Control.Frame = Frame;
            //            Control.Bounds = Bounds;
        }


        //        /// <summary>
        //        /// Draws the specified rect.
        //        /// </summary>
        //        /// <param name="rect">The rect.</param>
        //        public override void Draw(CoreGraphics.CGRect rect)
        //        {
        //            base.Draw(rect);
        //        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            switch (e.PropertyName)
            {
//                case "IsVisible":
//                    Control.Hidden = Element.IsVisible;
//                    break;
                case "IsEnabled":
                    Control.SetEnabled(Element.IsEnabled);
                    break;
                case "Checked":
                    Control.SetCheckState(Element.Checked ? CheckState.Checked : CheckState.Unchecked);
                    break;

            }
        }

    }
}

