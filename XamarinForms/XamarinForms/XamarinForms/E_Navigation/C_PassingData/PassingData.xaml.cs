using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.E_Navigation.C_PassingData.Models;

namespace XamarinForms.E_Navigation.C_PassingData
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PassingData : ContentPage
    {
        public PassingData()
        {
            InitializeComponent();
            PopulateListOfConstact();
        }

        public void PopulateListOfConstact()
        {
            friendListView.ItemsSource = new List<Friend>()
            {
                new Friend { Name = "Superman", ImageURL ="http://lorempixel.com/100/100/people/1/", Status = Status.Online},
                new Friend { Name = "Jazzman", ImageURL ="http://lorempixel.com/100/100/people/2/", Status = Status.Away},
                new Friend { Name = "Batman", ImageURL ="https://i.picsum.photos/id/2/100/100.jpg", Status = Status.Busy},
                new Friend { Name = "Azman", ImageURL ="https://i.picsum.photos/id/1/100/100.jpg", Status = Status.Offline},
            };
        }

        private void CellListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // SelectedItemChangedEventArgs 'e' which give us information of selected item e is a type of
            // object of selected item therefore you can conver it.

            //var friend = e.SelectedItem as Friend;
            //DisplayAlert("Item Selected: " + contact.Name, contact.Status.ToString(), "Ok"); ;

            friendListView.SelectedItem = null;
        }

        private async void CellListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var friend = e.Item as Friend;
            // To pass a data to target page we have 3 way:
            // 1. pass via constructor, DataInfoPage("Name", ClassData)
            // 2. Contact property, DataInfoPage(Name = name, Contact = contact)
            // 3. BindingContext, DataInfoPage( BindingContext = contact)

            await Navigation.PushAsync(new DataInfoPage(friend));
        }

        
    }
}