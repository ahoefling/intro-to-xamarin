using Ooui;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new
            {
                Description = "Test"
            };
        }

        public async void OnButtonClicked(object sender, EventArgs args)
        {
            await DisplayAlert("Button Clicked", $"You have clicked the button!", "OK");
        }

        private static Ooui.Element CreateElement()
        {
            var page = new MainPage();
            return page.GetOouiElement();
        }

        public static void Publish()
        {
            UI.Port = 8156;
            UI.Publish ("/main", CreateElement);
        }
    }
}
