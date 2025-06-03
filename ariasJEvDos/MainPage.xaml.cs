using System;
using Microsoft.Maui.Controls;
using ariasJEvDos.views;

namespace ariasJEvDos
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void VerChiste_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChistePage());

        }
        private async void SobreMi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutPage());
        }

    }

}
