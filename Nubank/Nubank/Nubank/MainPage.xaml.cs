using Nubank.View.Popup;
using Plugin.Fingerprint;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Nubank
{
    public partial class MainPage : ContentPage
    {

        public Command EnterCommand { get; set; }

        public Command OpenWarningCommand { get; set; }

        public MainPage()
        {
            InitializeComponent();

            EnterCommand = new Command(async() =>
            {
                var availability = await CrossFingerprint.Current.IsAvailableAsync();

                if (!availability)
                {
                    await DisplayAlert("Cuidado!", "Biometria não disponível", "Ok");
                    return;
                }

                var authResult = await CrossFingerprint.Current.AuthenticateAsync(new Plugin.Fingerprint.Abstractions.AuthenticationRequestConfiguration("Nubank", "Desbloqueie seu celular"));

                if (authResult.Authenticated)
                {
                    //OpenMainpage
                }
                else
                {
                    //Error
                }
            });

            OpenWarningCommand = new Command(async () =>
            {
                try
                {
                    await Browser.OpenAsync("https://www.youtube.com/watch?v=2SSOhoKvj0M", BrowserLaunchMode.SystemPreferred);
                }
                catch (Exception)
                {
                }
            });

            BindingContext = this;
        }

        private void switchBool_Toggled(object sender, ToggledEventArgs e)
        {
            try
            {
                if (switchBool.IsToggled)
                {
                    switchBool.ThumbColor = Color.FromHex("#8A05BE"); 
                }
                else 
                {
                    switchBool.ThumbColor = Color.White;
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
