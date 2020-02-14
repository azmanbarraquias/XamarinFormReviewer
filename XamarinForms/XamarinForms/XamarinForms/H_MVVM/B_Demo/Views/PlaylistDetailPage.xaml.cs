using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.H_MVVM.B_CodeBehindAndTestability.Models;

namespace XamarinForms.H_MVVM.B_CodeBehindAndTestability.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlaylistDetailPage : ContentPage
    {
        private readonly Playlist _playlist;

        public PlaylistDetailPage(Playlist playlist)
        {
            _playlist = playlist;

            InitializeComponent();

            title.Text = _playlist.Title;
        }
    }
}