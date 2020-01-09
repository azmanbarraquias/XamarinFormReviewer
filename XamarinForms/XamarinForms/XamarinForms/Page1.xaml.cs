using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        private PerseonDatabase _perseonDatabase = new PerseonDatabase();
        public Page1()
        {
            InitializeComponent();

            PeopleListViewMethpd();
        }

        private void Delete_Clicked(object sender, EventArgs e)
        {
            var personItem = (sender as MenuItem).CommandParameter as Person;
            DisplayAlert(personItem.Name, "Has being Deleted", "ok");
            _perseonDatabase.DeletePersonData(personItem);
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        public void PeopleListViewMethpd()
        {
            PeopleListView.ItemsSource = _perseonDatabase.GetPeopleInfo();
        }

        private void PeopleListView_Refreshing(object sender, EventArgs e)
        {
            PeopleListViewMethpd();
            PeopleListView.IsRefreshing = false;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class PerseonDatabase
    {
        private ObservableCollection<Person> _people = new ObservableCollection<Person>()
        {
            new Person { Name = "Azman", Age = 117},
            new Person { Name = "Jazzman", Age = 127},
            new Person { Name = "Barraquias", Age = 237}
        };

        public ObservableCollection<Person> GetPeopleInfo()
        {
            var oldPeople = from oldP in _people where oldP.Age  < 200 select oldP;
            var oc = new ObservableCollection<Person>(oldPeople);
            return oc;
        }

        public void DeletePersonData(Person person)
        {
            _people.Remove(person);
        }
    }
}