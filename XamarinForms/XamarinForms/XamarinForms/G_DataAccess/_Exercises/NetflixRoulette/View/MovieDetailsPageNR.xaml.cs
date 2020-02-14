using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.G_DataAccess._Exercises.NetflixRoulette.Models;
using XamarinForms.G_DataAccess._Exercises.NetflixRoulette.Services;

namespace XamarinForms.G_DataAccess._Exercises.NetflixRoulette.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MovieDetailsPageNR : ContentPage
    {
        private readonly MovieServiceNR _movieService = new MovieServiceNR();
        private readonly MovieNR _movie;

        public MovieDetailsPageNR(MovieNR movie)
        {
            //if (movie == null)
            //    throw new ArgumentNullException(nameof(movie)); same as,

            _movie = movie ?? throw new ArgumentNullException(nameof(movie));

            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            BindingContext = await _movieService.GetMovie(_movie.Title);

            base.OnAppearing();
        }
    }
}
