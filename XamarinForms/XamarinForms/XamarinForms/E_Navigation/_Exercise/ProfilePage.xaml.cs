using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.E_Navigation._Exercies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentPage
    {

        public ProfilePage()
        {
            InitializeComponent();

            string Name = "Azman Barraquias";
            string Description  = "Programmer/Gamer";
            string ImageURL = "Icon512.png";

            NameTxt.Text = Name;
            DescriptionTxt.Text = Description;
            ImageCircle.Source = ImageURL;
        }
    }
}