using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.D_Lists.Models;

namespace XamarinForms.D_Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class E_HandlingSelections : ContentPage
    {
        public E_HandlingSelections()
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

        private void CellListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // SelectedItemChangedEventArgs 'e' which give us information of selected item e is a type of
            // object of selected item therefore you can conver it.

            var contact = e.SelectedItem as Contact;
            DisplayAlert("Item Selected: " + contact.Name, contact.Status.ToString(), "Ok");;

            contactListView.SelectedItem = null;
        }

        private void CellListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Item Tapped: " + contact.Name, contact.Status.ToString(), "Ok");
        }
    }
}