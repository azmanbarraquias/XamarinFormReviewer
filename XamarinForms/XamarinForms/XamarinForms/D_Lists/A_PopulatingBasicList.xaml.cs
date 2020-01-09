using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.D_Lists
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class A_PopulatingBasicList : ContentPage
    {
        private readonly Random _rand = new Random();
        readonly ObservableCollection<string> names = new ObservableCollection<string>();
      

        public A_PopulatingBasicList()
        {
            InitializeComponent();
            PopulateBasicList();
        }

        public void PopulateBasicList()
        {
            listView.ItemsSource = names;

            // ObservableCollection allows items to be added after ItemsSource
            // is set and the UI will react to changes
            names.Add("Rob Finnerty" );
            names.Add("Bill Wrestler" );
            names.Add("Dr. Geri-Beth Hooper" );
            names.Add("Dr. Keith Joyce-Purdy" );
            names.Add("Sheri Spruce" );
            names.Add("Burt Indybrick" );
        }

        private void AddMoreButton(object sender, EventArgs e)
        {
            var randomNames = _rand.Next(0, names.Count);
            names.Add(names[randomNames]);
        }

        private void CellListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {


            var item = e.Item as string;
            DisplayAlert("Item Tapped: " + item, "", "Ok");
            listView.SelectedItem = null;
        }

        private void CellListView_ItemTapped1(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as string;
            DisplayAlert("Item Tapped: " + item, "", "Ok");
        }
    }
}