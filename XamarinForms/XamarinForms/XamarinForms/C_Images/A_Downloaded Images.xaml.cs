using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.C_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class A_Downloaded_Images : ContentPage
    {
        public A_Downloaded_Images()
        {
            InitializeComponent();
            // ImagesUI();
            ImageFromInternet();
            ImageFromInternet1();
      
        }

        public void ImageFromInternet()
        {
            ImageURLCode.Source = "https://i.picsum.photos/id/1084/536/354.jpg?grayscale";
            //ImageURLCode.CachingEnabled Cannot set CachingEnabled or CacheValidity.
 
        }

        public void ImageFromInternet1()
        {
            //
            var imageSource = new UriImageSource { Uri = new Uri("https://i.ibb.co/8s60w5M/azman.jpg") };
            //Default is True
            imageSource.CachingEnabled = false;
            //Default is 24hrs
            imageSource.CacheValidity = TimeSpan.FromHours(1);

            //Content = new Image { Source = imageSource };
            //or
            ImageURLCode1.Source = imageSource;

            ImageURLCode1.IsVisible = true;
            //MyImage.Source = "http://....jpg"
        }

        public void ImagesUI()
        {
            var webImage = new Image { Source = ImageSource.FromUri(new Uri("https://i.picsum.photos/id/866/536/354.jpg")) };
            Content = webImage;
        }
    }
}