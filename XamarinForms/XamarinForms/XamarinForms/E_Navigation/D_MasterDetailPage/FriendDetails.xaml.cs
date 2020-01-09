using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.E_Navigation.D_MasterDetailPage.Models;

namespace XamarinForms.E_Navigation.D_MasterDetailPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendDetails : ContentPage
    {
        public FriendDetails(Friend friend)
        {
            if (friend.Equals(null))
                throw new ArgumentNullException();

            BindingContext = friend;

            InitializeComponent();
        }

        public FriendDetails()
        {
            InitializeComponent();
        }

        protected override bool OnBackButtonPressed()
        {
            Navigation.PopAsync();
            return base.OnBackButtonPressed();

        }
    }
}