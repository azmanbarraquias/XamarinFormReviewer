using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.F_FormsAndSettingPages.ContactBook.Models;
using XamarinForms.F_FormsAndSettingPages.ContactBook.Storage;

namespace XamarinForms.F_FormsAndSettingPages.ContactBook.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactPageList : ContentPage
    {
        private readonly ContactServices _contactServices = new ContactServices();
        public ContactPageList()
        {
            InitializeComponent();
            GenerateContactList();
        }

        public void GenerateContactList()
        {
            ContactListView.ItemsSource = _contactServices.GetList();
        }

        private void EditContact_Clicked(object sender, EventArgs e)
        {
            var contactItem = (sender as MenuItem).CommandParameter as Contact;

            Navigation.PushAsync(new ContactDetailPage(contactItem, false));

        }

        private async void DeleteContact_Clicked(object sender, EventArgs e)
        {
            var contactItem = (sender as MenuItem).CommandParameter as Contact;

            var result = await DisplayAlert("Warning", string.Format("Are you sure you want to delete {0}", contactItem.FullName), "Yes", "No");
            if (result)
            {
                _contactServices.RemoveContact(contactItem);
            }
        }

        private async void AddNewContact(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ContactDetailPage(new Contact(), true));
            ContactListView.ItemsSource = _contactServices.GetList();
        }
    }
}