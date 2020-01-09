using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.E_Navigation.G_DisplayPopups
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DisplayPopups : ContentPage
    {
        public DisplayPopups()
        {
            InitializeComponent();
        }

        private async void DeleteClicked(object sender, EventArgs e)
        {
            var respond = await DisplayAlert("Warning!", "Are your sure you want to delete?...", "Yes", "No");
            if (respond)
            {
                await DisplayAlert("Note! " + respond, "Item Deleted", "ok");
            }
            else
            {
                await DisplayAlert("Note! " + respond, "Item not Deleted", "ok");
            }
        }

        private async void ActionSheet_Clicked(object sender, EventArgs e)
        {
            var respond = await DisplayActionSheet("Title (Menu)", "Cancel", "Delete", 
                "Share", "Email", "Copy Link");
            if (!string.IsNullOrEmpty(respond))
            {
                await DisplayAlert("Hi", "You select: " + respond, "ok");
            }
        }

        private async void ProptInput_Clicked(object sender, EventArgs e)
        {
            var inputRespond = await DisplayPromptAsync("Name", "Enter your name", "Ok", "Cancel", "ex. Tony Stark", 10, Keyboard.Default);
            if (!string.IsNullOrEmpty(inputRespond))
            {
                await DisplayAlert("Note:", "Your Input: " + inputRespond, "ok");
                GreatHeader.Text = inputRespond;
            }
        }
    }
}