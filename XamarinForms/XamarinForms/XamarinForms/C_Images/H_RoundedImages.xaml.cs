using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ImageCircle.Forms.Plugin.Abstractions;

namespace XamarinForms.C_Images
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class H_RoundedImages : ContentPage
    {
        public H_RoundedImages()
        {
            InitializeComponent();
        }
        public void ImageCircleDemo()
        {
            new CircleImage
            {
                BorderColor = Color.White,
                BorderThickness = 3,
                HeightRequest = 150,
                WidthRequest = 150,
                Aspect = Aspect.AspectFill,
                HorizontalOptions = LayoutOptions.Center,
                Source = UriImageSource.FromUri(new Uri("http://upload.wikimedia.org/wikipedia/commons/5/55/Tamarin_portrait.JPG"))
            };
        }
    }
}