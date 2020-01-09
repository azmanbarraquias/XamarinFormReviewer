using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.F_FormsAndSettingPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E_EntryAndEditor : ContentPage
    {
        public E_EntryAndEditor()
        {
            InitializeComponent();
        }
        private void Entry_Completed(object sender, EventArgs e)
        {
            Label.Text = (sender as Entry).Text + " [Password Input Finish]";
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label.Text = e.NewTextValue + " [User Input Finish]";
        }
    }
}