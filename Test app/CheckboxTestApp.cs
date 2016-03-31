using System;

using Xamarin.Forms;
using Messier16.Forms.Controls;
using System.Linq;

namespace CheckboxTestApp
{
    public class App : Application
    {
        public App()
        {

            // The root page of your application
            MainPage = new NavigationPage( new XamlPage());
        }

    }
}

