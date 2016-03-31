using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace CheckboxTestApp
{
    public partial class XamlPage : ContentPage
    {
        public XamlPage()
        {
            BindingContext = new DummyViewModel();
            InitializeComponent();
        }
    }
}

