using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace XamarinForms.G_DataAccess
{
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public string PostInfo { get { return string.Format($"{UserId} {Title}"); } }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class H_ConsumingRESTfulServices : ContentPage
    {
        private const string jsonPlaceHolderURL = "https://jsonplaceholder.typicode.com/posts";

        private readonly HttpClient _httpClient = new HttpClient();

        private ObservableCollection<Post> _posts;

        public H_ConsumingRESTfulServices()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            var content = await _httpClient.GetStringAsync(jsonPlaceHolderURL);

            var posts = JsonConvert.DeserializeObject<List<Post>>(content);

            _posts = new ObservableCollection<Post>(posts);

            await DisplayAlert("", $"{posts.Count} of post found", "ok");

            postsListView.ItemsSource = _posts;

            base.OnAppearing();
        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post { Id = 0, Body = "This is text sample", Title = "Title sampe " + DateTime.Now, UserId = 0 };

            var postContent = JsonConvert.SerializeObject(post);

            _posts.Insert(0, post);

            await _httpClient.PostAsync(jsonPlaceHolderURL, new StringContent(postContent));


            //_posts.Add(post);
        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            post.Title += " UPDATED";

            var postContent = JsonConvert.SerializeObject(post);

            await _httpClient.PutAsync(jsonPlaceHolderURL + "/" + post.Id, new StringContent(postContent));

        }

        async void OnDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];

            _posts.Remove(post);

            await _httpClient.DeleteAsync(jsonPlaceHolderURL + "/" + post.Id);
        }
    }
}