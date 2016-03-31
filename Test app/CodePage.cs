using System;

using Xamarin.Forms;
using Messier16.Forms.Controls;
using System.Linq;

namespace CheckboxTestApp
{
    public class CodePage : ContentPage
    {
        public CodePage()
        {
            Title = "Code Page";

            var cb1 = new Checkbox() { WidthRequest = 55, StyleId = "check1" };
            var cb2 = new Checkbox() { WidthRequest = 45, IsEnabled = false, StyleId = "check2" };
            var cb3 = new Checkbox() { WidthRequest = 35, Checked = true, StyleId = "check3" };
            var cb4 = new Checkbox() { IsVisible = cb2.Checked };

            cb1.CheckedChanged += 
                (sender, e) =>
            { 
                cb2.IsEnabled = e.IsChecked;
                cb3.Checked = !e.IsChecked;
            };

            cb2.CheckedChanged +=
                (sender, e) => cb4.IsVisible = e.IsChecked;

            var items = Enumerable.Range(0, 30)
                .Select(i => new SelectableItem { 
                    Text = "Item " + i,
                    IsVisible = true,
                    IsSelectable = i % 2 == 0,
                    IsChecked = i % 3 == 0
                });

            var selectableList = new ListView()
            {
                ItemsSource = items
            };

            selectableList.ItemTemplate = new DataTemplate(typeof(SelectableCell));
            selectableList.ItemTemplate.SetBinding(SelectableCell.TextProperty, "Text");
            selectableList.ItemTemplate.SetBinding(SelectableCell.CheckboxEnabledProperty, "IsSelectable");
            selectableList.ItemTemplate.SetBinding(SelectableCell.CheckboxVisibleProperty, "IsVisible");
            selectableList.ItemTemplate.SetBinding(SelectableCell.CheckboxCheckedProperty, "IsChecked");

            var checkboxes = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    cb1,
                    cb2,
                    cb3,
                    cb4
                }
            };
            
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Children =
                {
                    checkboxes,
                    selectableList
                }
            };
        }
    }
}


