using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.E_Navigation.C_PassingData.Models;

namespace XamarinForms.E_Navigation.C_PassingData
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataInfoPage : ContentPage
    {
        public DataInfoPage(Friend friend)
        {
            if (friend.Equals(null))
            throw new ArgumentNullException();

            BindingContext = friend;

            InitializeComponent();
        }

        public DataInfoPage()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PopAsync();
            return true;
        }
    }
}