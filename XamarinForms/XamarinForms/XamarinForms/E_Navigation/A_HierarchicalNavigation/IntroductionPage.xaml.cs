using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.E_Navigation.A_HierarchicalNavigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage()
        {
            InitializeComponent();
        }

        private async void BackButton(object sender, EventArgs e)
        {
            // active page therefore we pop this page to go back
            await Navigation.PopAsync();
        }

        protected override bool OnBackButtonPressed()
        {
            return true; // to disable back button
            //return base.OnBackButtonPressed();  
        }
    }
}