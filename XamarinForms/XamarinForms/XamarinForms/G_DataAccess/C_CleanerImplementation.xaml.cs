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
    public partial class C_CleanerImplementation : ContentPage
    {
        //private readonly App appClass = Application.Current as App;

        public C_CleanerImplementation()
        {
            InitializeComponent();

            BindingContext = Application.Current;

            //or 

            //title.Text = appClass.Title;
            //notificationsEnabled.On = appClass.NotificationEnabled;
        }


        //private void OnChange(object sender, EventArgs e)
        //{

        //    appClass.Title = title.Text;
        //    appClass.NotificationEnabled = notificationsEnabled.On;

        //    Application.Current.SavePropertiesAsync(); // Trancient Data
        //    DisplayAlert("Save", "Data Save", "ok");
        //}

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
        }
    }
}