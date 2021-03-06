﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SimpleApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new
            {
                Description = "Welcome to Xamarin Intro Class!",
                ButtonText = "More Complex Page"
            };
        }

        private async void Alert_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Alert", "This is an alert message", "OK");
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OouiSamplePage());
        }
    }
}