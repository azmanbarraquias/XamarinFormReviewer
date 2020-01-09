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
    public partial class G_PullToRefresh : ContentPage
    {
        private ObservableCollection<Contact> _listOfContact;
        public G_PullToRefresh()
        {
            InitializeComponent();
            PopulateListOfConstact();
        }

        public void PopulateListOfConstact()
        {
            contactListView.ItemsSource = GetContact();
        }

        public ObservableCollection<Contact> GetContact()
        {
            // this method examble when we make a call to remote service or api
            // therefore this return to us the list of contact from a service sample
            return _listOfContact = new ObservableCollection<Contact>()
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

            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Item Selected: " + contact.Name, contact.Status.ToString(), "Ok"); ;

            //contactListView.SelectedItem = null;
        }

        private void CellListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact;
            DisplayAlert("Item Tapped: " + contact.Name, contact.Status.ToString(), "Ok"); ;
        }

        private void Call_Clicked(object sender, EventArgs e)
        {
            // sender is a menu item there fore we can convert it to menu item
            var menuItem = sender as MenuItem;
            var contactItem = menuItem.CommandParameter as Contact;
            DisplayAlert("Call", string.Format("You Call: {0}", contactItem.Name), "Ok");

        }

        private async void Delete_Clicked(object sender, EventArgs e)
        {
            var menuItemToDelete = ((MenuItem)sender).CommandParameter as Contact;
            var result = await DisplayAlert("Warning", string.Format("Are you sure you want to delete {0}", menuItemToDelete.Name), "Yes", "No");
            if (result)
            {
                _listOfContact.Remove(menuItemToDelete);
            }
        }

        private void ContactListView_Refreshing(object sender, EventArgs e)
        {
            contactListView.ItemsSource = GetContact();

            contactListView.IsRefreshing = false;

            //or

            //contactListView.EndRefresh();
        }
    }
}