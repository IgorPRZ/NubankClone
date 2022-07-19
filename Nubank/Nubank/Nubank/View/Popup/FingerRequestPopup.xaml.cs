using Plugin.Fingerprint;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Nubank.View.Popup
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FingerRequestPopup : Rg.Plugins.Popup.Pages.PopupPage
    {
        public FingerRequestPopup()
        {
            InitializeComponent();

            BindingContext = this;

            Init();
        }


        private async void Init() 
        {
            try
            {
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}