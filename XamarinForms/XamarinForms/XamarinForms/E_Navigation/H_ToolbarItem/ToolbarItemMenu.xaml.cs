using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.E_Navigation.H_ToolbarItem
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToolbarItemMenu : ContentPage
    {
        public ToolbarItemMenu()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Activated(object sender, EventArgs e)
        {
            var getTxt = (sender as ToolbarItem).Text;
            DisplayAlert("", "This is menu item: " + getTxt, "Ok");
        }

        private void ToolbarItem_Activated_1(object sender, EventArgs e)
        {
            var getTxt = (sender as ToolbarItem).Text;
            DisplayAlert("", "This is menu item: " + getTxt, "Ok");
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var getTxt = (sender as ToolbarItem).Text;
            DisplayAlert("", "This is menu item: " + getTxt, "Ok");
        }
    }
}