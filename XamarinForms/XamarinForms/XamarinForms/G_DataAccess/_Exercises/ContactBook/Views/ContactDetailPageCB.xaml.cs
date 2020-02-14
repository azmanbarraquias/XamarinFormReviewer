using SQLite;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.G_DataAccess._Exercises.ContactBook.Models;
using XamarinForms.G_DataAccess.Persistence;

namespace XamarinForms.G_DataAccess._Exercises.ContactBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactDetailPageCB : ContentPage
    {
        public event EventHandler<ContactCB> ContactAdded;
        public event EventHandler<ContactCB> ContactUpdated;

        private readonly SQLiteAsyncConnection _connection;

        public ContactDetailPageCB(ContactCB ContactCB)
        {
            if (ContactCB == null)
                throw new ArgumentNullException(nameof(ContactCB));

            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();

            BindingContext = new ContactCB
            {
                Id = ContactCB.Id,
                FirstName = ContactCB.FirstName,
                LastName = ContactCB.LastName,
                Phone = ContactCB.Phone,
                Email = ContactCB.Email,
                IsBlocked = ContactCB.IsBlocked
            };
        }

        async void OnSave(object sender, System.EventArgs e)
        {
            var ContactCB = BindingContext as ContactCB;

            if (string.IsNullOrWhiteSpace(ContactCB.FullName))
            {
                await DisplayAlert("Error", "Please enter the name.", "OK");
                return;
            }

            if (ContactCB.Id == 0)
            {
                await _connection.InsertAsync(ContactCB);

                ContactAdded?.Invoke(this, ContactCB);
            }
            else
            {
                await _connection.UpdateAsync(ContactCB);

                ContactUpdated?.Invoke(this, ContactCB);
            }

            await Navigation.PopAsync();
        }
    }
}
