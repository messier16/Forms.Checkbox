using System;

using Xamarin.Forms;
using Messier16.Forms.Controls;

namespace CheckboxTestApp
{
    public class App : Application
    {
        public App()
        {

            var cb1 = new Checkbox();
            var cb2 = new Checkbox() { IsEnabled = false };
            var cb3 = new Checkbox() { Checked = true };
            var cb4 = new Checkbox() { IsVisible = false };

            cb1.CheckedChanged += 
                (sender, e) =>
            { 
                    cb2.IsEnabled = e.Value;
                    cb3.Checked = !cb1.Checked;
                    cb4.IsVisible = cb2.Checked;
            };

            // The root page of your application
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                                    cb1,
                                    cb2,
                                    cb3,
                                    cb4
                    }
                }
            };
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

