using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.G_DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class B_ApplicationProperties : ContentPage
    {
        public B_ApplicationProperties()
        {
            InitializeComponent();

            if (Application.Current.Properties.ContainsKey("Name"))
            {
                title.Text = Application.Current.Properties["Name"].ToString();
                DisplayAlert("Restore", Application.Current.Properties["Name"].ToString() + "restore", "Ok");
            }

            if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
            {
                notificationsEnabled.On = (bool)Application.Current.Properties["NotificationsEnabled"];
                DisplayAlert("Restore", Application.Current.Properties["NotificationsEnabled"] + "restore", "Ok");
            }
        }


        private void OnChange(object sender, EventArgs e)
        {
            Application.Current.Properties["Name"] = title.Text;
            Application.Current.Properties["NotificationsEnabled"] = notificationsEnabled.On;
            //This data will not save immediate, Presistent only hapens when the application goes to sleep mode. 
            Application.Current.SavePropertiesAsync(); //This way we dont have to wait when to app goes to sleep mode.
            DisplayAlert("Save", "Save", "ok");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}