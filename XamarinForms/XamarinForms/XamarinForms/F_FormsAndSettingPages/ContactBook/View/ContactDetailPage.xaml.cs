using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.F_FormsAndSettingPages.ContactBook.Models;
using XamarinForms.F_FormsAndSettingPages.ContactBook.Storage;

namespace XamarinForms.F_FormsAndSettingPages.ContactBook.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPage : ContentPage
    {
        private readonly Contact _contact;

        private readonly bool _newContact;

        private readonly ContactServices _contactServices = new ContactServices();

        public ContactDetailPage()
        {
            InitializeComponent();
        }

        public ContactDetailPage(Contact contact, bool newContact)
        {
            InitializeComponent();

            _newContact = newContact;

            BindingContext = contact;
            _contact = contact;
        }

        private async void SaveContact(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstName.Text) && string.IsNullOrWhiteSpace(lastName.Text))
            {
                await DisplayAlert("Warning", "First name and last name must have value", "Close");
            }
            else
            {
                var result = await DisplayAlert("Contact", "Are you sure you want to save?", "Yes", "No");
                if (_newContact.Equals(false))
                {
                    if (result)
                    {
                        _contact.FirstName = firstName.Text;
                        _contact.LastName = lastName.Text;
                        _contact.Phone = phone.Text;
                        _contact.Email = email.Text;
                        _contact.Blocked = true;
                        await DisplayAlert("Contact", "has being saved", "close");
                        await Navigation.PopAsync();
                    }
                    else
                    {
                        await DisplayAlert("Contact", "has not being saved", "close");
                    }
                }
                else
                {
                    AddNewContactSave();
                    await DisplayAlert("Contact", "new contact has being saved", "close");

                    await Navigation.PopAsync();
                }
            }
        }

        public void AddNewContactSave()
        {
            _contactServices.AddNewContact(new Contact
            {
                FirstName = firstName.Text,
                LastName = lastName.Text,
                Phone = phone.Text,
                Email = email.Text
            });
        }
    }
}