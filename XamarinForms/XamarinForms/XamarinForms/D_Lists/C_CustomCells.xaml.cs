using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.D_Lists.Models;

namespace XamarinForms.D_Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_CustomCells : ContentPage
    {
        public C_CustomCells()
        {
            InitializeComponent();
            PopulateListOfConstact();
        }

        public void PopulateListOfConstact()
        {
            contactListView.ItemsSource = new List<Contact>()
            {
                new Contact { Name = "Superman", ImageURL ="http://lorempixel.com/100/100/people/1/", Status = Status.Online},
                new Contact { Name = "Jazzman", ImageURL ="http://lorempixel.com/100/100/people/2/", Status = Status.Away},
                new Contact { Name = "Batman", ImageURL ="https://i.picsum.photos/id/2/100/100.jpg", Status = Status.Busy},
                new Contact { Name = "Azman", ImageURL ="https://i.picsum.photos/id/1/100/100.jpg", Status = Status.Offline},
            };
        }

        private void FollowButton(object sender, EventArgs e)
        {
            var menuItem = (sender as Button).CommandParameter as Contact;
            DisplayAlert("Note!", "You follow, "+menuItem.Name, "Ok");
        }
    }
}