using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.C_Images._Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PhotoGallery : ContentPage
    {
        private Random _rand = new Random();
        //private List<int> previousImageURL = new List<int>();
        private int _indext = 0;
        private readonly int _maxIndex = 1000;
        private readonly int _minIndex = 0;

        public PhotoGallery()
        {
            InitializeComponent();

            LoadImage();
        }

        private void PreviousButton(object sender, EventArgs e)
        {
            if (!_indext.Equals(_minIndex))
            {
                _indext--;
            }
            LoadImage();
        }

        private void NextButton(object sender, EventArgs e)
        {
            if (!_indext.Equals(_maxIndex))
            {
                _indext++;
            }
            else
            {
                _indext = 0;
            }
            LoadImage();
        }

        public void LoadImage()
        {
            var imageURL = new UriImageSource
            {
                Uri = new Uri(string.Format(@"https://i.picsum.photos/id/{0}/1920/1080.jpg", _indext)),
                CachingEnabled = false
            };
            ImageURLTitle.Text = imageURL.Uri.ToString();
            MainViewImages.Source = imageURL;
        }


        private void RandomButton(object sender, EventArgs e)
        {
            int randIndex = _rand.Next(_minIndex, _maxIndex + 1);
            _indext = randIndex;
            LoadImage();
        }
    }
}