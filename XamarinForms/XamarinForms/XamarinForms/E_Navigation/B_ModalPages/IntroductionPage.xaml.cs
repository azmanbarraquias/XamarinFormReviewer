using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.E_Navigation.B_ModalPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class IntroductionPage : ContentPage
    {
        public IntroductionPage(string name = "")
        {
            InitializeComponent();

            HeaderText.Text += name;
        }
        private async void BackButton(object sender, EventArgs e)
        {
            // active page therefore we pop this page to go back
            await Navigation.PopModalAsync(true);
        }

        protected override bool OnBackButtonPressed()
        {
            return true; // to disable back button
            //return base.OnBackButtonPressed();  
        }
    }
}