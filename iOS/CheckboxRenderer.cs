// Code ported from Obj-C to C#
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
    public class CheckboxRenderer : ViewRenderer<Checkbox, M13Checkbox>
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public new static void Init()
        {
            var temp = DateTime.Now;
        }

        private CGRect _originalBounds;

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
                    var width = (double)Constants.CheckboxDefaultHeight;
                    if (Element.WidthRequest >= 0)
                    {
                        width = Element.WidthRequest;
                    }
                    var checkBox = new M13Checkbox(new CGRect(0, 0, width, width));
                    checkBox.Bounds = new CGRect(0, 0, width, width);
                    checkBox.CheckedChanged += (s, args) => Element.Checked = args.Checked;
                    SetNativeControl(checkBox);

                    // Issue with list rendering
                    _originalBounds = checkBox.Bounds;
                }
                Control.SetCheckState(e.NewElement.Checked
                    ? CheckboxState.Checked : CheckboxState.Unchecked);
                Control.SetEnabled(e.NewElement.IsEnabled);
                Control.Bounds = _originalBounds;
            }
        }

#if DEBUG
        private string GetBounds(CGRect rect)
        {
            return String.Format(" X:{0} Y:{1} H:{2} W:{3}", rect.X, rect.Y, rect.Height, rect.Width);
        }
#endif


        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            switch (e.PropertyName)
            {
                //case "IsVisible":
                //    Control.Hidden = Element.IsVisible;
                //    break;
                case "IsEnabled":
                    Control.SetEnabled(Element.IsEnabled);
                    break;
                case "Checked":
                    Control.SetCheckState(Element.Checked ? CheckboxState.Checked : CheckboxState.Unchecked);
                    break;

            }
        }

    }
}

