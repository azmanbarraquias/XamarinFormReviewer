using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.H_MVVM.B_CodeBehindAndTestability.Models;

namespace XamarinForms.H_MVVM.B_CodeBehindAndTestability.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistsPage : ContentPage
    {
        private readonly ObservableCollection<Playlist> _playlists = new ObservableCollection<Playlist>();

        public PlaylistsPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            playlistsListView.ItemsSource = _playlists;

            base.OnAppearing();
        }

        void OnAddPlaylist(object sender, System.EventArgs e)
        {
            var newPlaylist = "Playlist " + (_playlists.Count + 1);

            _playlists.Add(new Playlist { Title = newPlaylist });

            this.Title = $"{_playlists.Count} Playlists";
        }

        void OnPlaylistSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var playlist = e.SelectedItem as Playlist;
            playlist.IsFavorite = !playlist.IsFavorite;

            playlistsListView.SelectedItem = null;

            //await Navigation.PushAsync (new PlaylistDetailPage(playlist));
        }
    }
}