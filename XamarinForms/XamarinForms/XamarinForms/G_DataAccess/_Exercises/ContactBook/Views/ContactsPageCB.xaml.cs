using SQLite;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.G_DataAccess._Exercises.ContactBook.Models;
using XamarinForms.G_DataAccess.Persistence;

namespace XamarinForms.G_DataAccess._Exercises.ContactBook.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class ContactsPageCB : ContentPage
    {
        private ObservableCollection<ContactCB> _contacts;
        private readonly SQLiteAsyncConnection _connection;
        private bool _isDataLoaded;

        public ContactsPageCB()
        {
            InitializeComponent();

            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override async void OnAppearing()
        {
            // In a multi-page app, everytime we come back to this page, OnAppearing
            // method is called, but we want to load the data only the first time
            // this page is loaded. In other words, when we go to ContactDetailPage
            // and come back, we don't want to reload the data. The data is already
            // there. We can control this using a switch: isDataLoaded.
            if (_isDataLoaded)
                return;

            _isDataLoaded = true;

            // I've extracted the logic for loading data into LoadData method. 
            // Now the code in OnAppearing method looks a lot cleaner. The 
            // purpose is very explicit. If data is loaded, return, otherwise,
            // load data. Details of loading the data is delegated to LoadData
            // method. 
            await LoadData();

            base.OnAppearing();
        }

        // Note that this method returns a Task, instead of void. Void should 
        // only be used for event handlers (e.g. OnAppearing). In all other cases,
        // you should return a Task or Task<T>.
        private async Task LoadData()
        {
            await _connection.CreateTableAsync<ContactCB>();

            var contactsList = await _connection.Table<ContactCB>().ToListAsync();

            _contacts = new ObservableCollection<ContactCB>(contactsList);
            contactsListView.ItemsSource = _contacts;
        }

        async void OnAddContact(object sender, System.EventArgs e)
        {
            var page = new ContactDetailPageCB(new ContactCB());

            page.ContactAdded += (source, ContactCB) =>
            {
                _contacts.Add(ContactCB);
            };

            await Navigation.PushAsync(page);
        }

        async void OnContactSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (contactsListView.SelectedItem == null)
                return;

            var selectedContact = e.SelectedItem as ContactCB;

            contactsListView.SelectedItem = null;

            var page = new ContactDetailPageCB(selectedContact);
            page.ContactUpdated += (source, ContactCB) =>
            {
                selectedContact.Id = ContactCB.Id;
                selectedContact.FirstName = ContactCB.FirstName;
                selectedContact.LastName = ContactCB.LastName;
                selectedContact.Phone = ContactCB.Phone;
                selectedContact.Email = ContactCB.Email;
                selectedContact.IsBlocked = ContactCB.IsBlocked;
            };

            await Navigation.PushAsync(page);
        }

        async void OnDeleteContact(object sender, System.EventArgs e)
        {
            var ContactCB = (sender as MenuItem).CommandParameter as ContactCB;

            if (await DisplayAlert("Warning", $"Are you sure you want to delete {ContactCB.FullName}?", "Yes", "No"))
            {
                _contacts.Remove(ContactCB);

                await _connection.DeleteAsync(ContactCB);
            }
        }
    }
}
