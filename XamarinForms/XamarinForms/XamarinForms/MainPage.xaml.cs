using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinForms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private int _numberOfClick = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void ClickMeButton(object sender, EventArgs e)
        {

            // sender - object which is source of the event
            // EventArgs - additional detail of event
            // DisplayAlert Method - Inherent from ContentPage, which
            // is the BaseClass
            // You can add more form "ok" like "ok", "no"

            // await - wait for some result
            bool x = await DisplayAlert(string.Format("Chnage Color ({0})", ++_numberOfClick), "Message, Hello!", "Blue", "Red");
            if (x.Equals(true))
            {
                await DisplayAlert("", "Button Color Change to Blue", "Ok");
                (sender as Button).BackgroundColor = Color.Blue;
            }
            else
            {
                await DisplayAlert("", "Button Color Change to Red", "Ok");
                (sender as Button).BackgroundColor = Color.Red;
            }
        }
    }
}
