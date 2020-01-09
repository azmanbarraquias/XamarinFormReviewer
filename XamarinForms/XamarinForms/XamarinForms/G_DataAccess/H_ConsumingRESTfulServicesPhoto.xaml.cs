using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.G_DataAccess.Models;

namespace XamarinForms.G_DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class H_ConsumingRESTfulServicesPhoto : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/photos";

        private readonly HttpClient _client = new HttpClient();
        private readonly ObservableCollection<Photo> photoList = new ObservableCollection<Photo>();

        public H_ConsumingRESTfulServicesPhoto()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var photoContent = await _client.GetStringAsync(Url);
            var phototp = JsonConvert.DeserializeObject<List<Photo>>(photoContent);
           
            foreach (var photo in phototp)
            {
                if (photo.Id == 101)
                {
                    break;
                }
                //var newTitleName = photo.Title;
                //photo.Title = null;
                //photo.Title = string.Format("id:{0} {1}", photo.Id, newTitleName);
                photoList.Add(photo);
            }

            photoListView.ItemsSource = photoList;

        }

        private async void CellListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var photoItem = e.Item as Photo;
            await DisplayAlert(photoItem.Url, photoItem.Title, "Ok");
        }
    }
}