using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Net.Http;
using XamarinForms.G_DataAccess.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms.Internals;

namespace XamarinForms.G_DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class H_ConsumingRESTfulServicesPost : ContentPage
    {

        private const string Url = "https://jsonplaceholder.typicode.com/posts";

        private readonly HttpClient _client = new HttpClient();
        private readonly ObservableCollection<Post> postsList = new ObservableCollection<Post>();
   
        public H_ConsumingRESTfulServicesPost()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var postContent = await _client.GetStringAsync(Url);
            var postp = JsonConvert.DeserializeObject<List<Post>>(postContent);
            await DisplayAlert("", postContent, "Ok");
            foreach (var post in postp)
            {
                var newTitleName = post.Title;
                post.Title = null;
                post.Title = string.Format("id:{0} {1}", post.Id, newTitleName);
                postsList.Add(post);
            }

            PostListView.ItemsSource = postsList;

        }

        private async void CellListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var postItem = e.Item as Post;
            await DisplayAlert(postItem.Title, postItem.Body, "Ok");
        }
    }
}