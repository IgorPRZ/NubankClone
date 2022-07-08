using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Nubank
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
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
