using System;

using Xamarin.Forms;
using Messier16.Forms.Controls;

namespace CheckboxTestApp
{
    public class SelectableCell : ViewCell
    {
        public static readonly BindableProperty TextProperty =
            BindableProperty.Create("Text", typeof(string), typeof(SelectableCell), "Charmander");

        public static readonly BindableProperty CheckboxEnabledProperty =
            BindableProperty.Create("CheckboxEnabled", typeof(bool), typeof(SelectableCell), true);

        public static readonly BindableProperty CheckboxVisibleProperty =
            BindableProperty.Create("CellEnabled", typeof(bool), typeof(SelectableCell), true);

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        public bool CheckboxEnabled
        {
            get { return (bool)GetValue(CheckboxEnabledProperty); }
            set { SetValue(CheckboxEnabledProperty, value); }
        }

        public bool CheckboxVisible
        {
            get { return (bool)GetValue(CheckboxVisibleProperty); }
            set { SetValue(CheckboxVisibleProperty, value); }
        }

        Label lbName;
        Checkbox cb;

#if DEBUG
        /// <summary>
        /// The checked state property.
        /// </summary>
        public static readonly BindableProperty TestProperty =
            BindableProperty.Create("Test",
                typeof(string),
                typeof(SelectableCell),
                "Test", BindingMode.TwoWay);

        /// <summary>
        /// Gets or sets a value indicating whether the control is checked.
        /// </summary>
        /// <value>The checked state.</value>
        public string Test
        {
            get
            {
                return (string)GetValue(TestProperty);
            }

            set
            {
                SetValue(TestProperty, value);
            }
        }
#endif

        public SelectableCell()
        {
            lbName = new Label { HorizontalOptions = LayoutOptions.StartAndExpand };

            Grid infoLayout = new Grid
                {
                    ColumnDefinitions = 
                        {
                            new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) },
                        },
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };

            infoLayout.Children.Add(lbName, 0, 0);

            var cellWrapper = new Grid
                {
                    Padding = 10,
                    ColumnDefinitions = 
                        {
                            new ColumnDefinition { Width = new GridLength(1,GridUnitType.Auto) },
                            new ColumnDefinition { Width = new GridLength(1,GridUnitType.Star) },
                        }
                };

            cb = new Checkbox();
            cellWrapper.Children.Add(cb, 0, 0);
            cb.IsEnabled = false;
            cb.SetBinding(Checkbox.CheckedProperty, "IsSelected");
            cellWrapper.Children.Add(infoLayout, 1, 0);

            View = cellWrapper;
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                lbName.Text = Text;
                cb.IsEnabled = CheckboxEnabled;
                cb.IsVisible = CheckboxVisible;
#if DEBUG
                cb.Test = Test;
#endif
            }
        }
    }
}


