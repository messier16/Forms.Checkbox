using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messier16.Forms.Controls;
using Messier16.Forms.Uwp.Controls;
using Xamarin.Forms.Platform.UWP;
using Windows.UI.Xaml.Controls;
using System.ComponentModel;

[assembly: ExportRenderer(typeof(Checkbox), typeof(CheckboxRenderer))]
namespace Messier16.Forms.Uwp.Controls

{
    public class CheckboxRenderer :  ViewRenderer<Checkbox, CheckBox>
    {
        /// <summary>
        /// Used for registration with dependency service
        /// </summary>
        public new static void Init()
        {
            var temp = DateTime.Now;
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Checkbox> e)
        {
            base.OnElementChanged(e);

            if (Element == null)
                return;

            if (Control == null)
            {
                var checkBox = new CheckBox();
                checkBox.Checked += CheckBox_Checked;
                checkBox.Unchecked += CheckBox_Unchecked;
                SetNativeControl(checkBox);
            }
            
        }

        private void CheckBox_Unchecked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Element.Checked = Control.IsChecked.GetValueOrDefault();
        }

        private void CheckBox_Checked(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            Element.Checked = Control.IsChecked.GetValueOrDefault();
        }

        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
            switch (e.PropertyName)
            {
                //case "IsVisible":
                //    Control.Hidden = Element.IsVisible;
                //    break;
                case "IsEnabled":
                    Control.IsEnabled = Element.IsEnabled;
                    break;
                case "Checked":
                    Control.IsChecked = Element.Checked;
                    break;

            }
        }
    }
}
