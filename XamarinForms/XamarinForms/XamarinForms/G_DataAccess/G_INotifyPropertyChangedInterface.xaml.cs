using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.G_DataAccess.Persistence;

namespace XamarinForms.G_DataAccess
{
    // [Table("Recipes")]
    public class Recipe2 : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        private string _name;

        [MaxLength(255)]
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (_name == value)
                    return;

                _name = value;

                OnPropertyChanged();
            }
        }

        private void OnPropertyChanged([CallerMemberName]string propertyName= null)
        {
            //if (PropertyChanged !=null)
            //{
            //    PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            //} same as,
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class G_INotifyPropertyChangedInterface : ContentPage
    {
        private readonly SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe2> _recipes;

        public G_INotifyPropertyChangedInterface()
        {
            InitializeComponent();

            // Gate way to database
            _connection = DependencyService.Get<ISQLiteDb>().GetConnection();
        }

        protected override void OnAppearing()
        {

            LoadRecipe();

            base.OnAppearing();
        }

        public async void LoadRecipe()
        {

            await _connection.CreateTableAsync<Recipe2>();

            var recipes = await _connection.Table<Recipe2>().ToListAsync();

            _recipes = new ObservableCollection<Recipe2>(recipes);

            ListViewItems.ItemsSource = _recipes;
        }


        private async void OnAdd(object sender, EventArgs e)
        {
            var recipe = new Recipe2 { Name = "Adobo " + DateTime.Now.ToString("HH:mm:ss") };

            await _connection.InsertAsync(recipe);

            _recipes.Add(recipe);

        }

        private async void OnUpdate(object sender, EventArgs e)
        {
            if (_recipes.Count != 0)
            {
                var recipe = _recipes[_recipes.Count - 1];
                recipe.Name += " Update";
                await _connection.UpdateAsync(recipe);
            }
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            if (_recipes.Count != 0)
            {
                var recipe = _recipes[0];
                await _connection.DeleteAsync(recipe);
                _recipes.Remove(recipe);
            }
        }

        private void OnReload(object sender, EventArgs e)
        {
            LoadRecipe();
        }

        private void OnRefresh(object sender, EventArgs e)
        {
            LoadRecipe();
            ListViewItems.IsRefreshing = false;
        }
    }
}