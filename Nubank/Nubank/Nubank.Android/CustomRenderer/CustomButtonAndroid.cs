using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Nubank.Droid.CustomRenderer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(Xamarin.Forms.Button), typeof(CustomButtonAndroid))]
namespace Nubank.Droid.CustomRenderer
{

    public class CustomButtonAndroid: ButtonRenderer
    {
        public CustomButtonAndroid(Context context) : base(context)
        {

        }


        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                Control.SetAllCaps(false);
            }
        }
    }
}