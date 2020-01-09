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
    public partial class WelcomePage : ContentPage
    {
        public WelcomePage()
        {
            InitializeComponent();

           
        }
        private async void NextButton(object sender, EventArgs e)
        {
            // We pop a new page on top of this page
            await Navigation.PushModalAsync(new IntroductionPage(" Azman Barraquias"), true);
        }
    }
}