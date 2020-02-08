using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.G_DataAccess.Persistence;

namespace XamarinForms.G_DataAccess
{
  // [Table("Recipes")]
    public class Recipe
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class F_SQLitePCL : ContentPage
    {
        private readonly SQLiteAsyncConnection _connection;
        private ObservableCollection<Recipe> _recipes;
       
        public F_SQLitePCL()
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

            await _connection.CreateTableAsync<Recipe>();

            var recipes = await _connection.Table<Recipe>().ToListAsync();

            _recipes = new ObservableCollection<Recipe>(recipes);

            ListViewItems.ItemsSource = _recipes;
        }


        private async void OnAdd(object sender, EventArgs e)
        {
            var recipe = new Recipe { Name = "Adobo " + DateTime.Now.ToString("HH:mm:ss") };

            await _connection.InsertAsync(recipe);

            _recipes.Add(recipe);

        }

        private async void OnUpdate(object sender, EventArgs e)
        {
            if (_recipes.Count != 0)
            {
                var recipe = _recipes[0];
                recipe.Name += " Update";
                await _connection.UpdateAsync(recipe);
            }
        }

        private async void OnDelete(object sender, EventArgs e)
        {
            if (_recipes.Count !=  0)
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