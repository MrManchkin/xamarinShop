using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace rent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterUI : ContentPage
    {
        public RegisterUI()
        {
            InitializeComponent();
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new LoginUI());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Falls", "This operation is not available at this time", "OK");
        }
    }
}