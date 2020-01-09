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
    public partial class F__PlatformSpecificImages : ContentPage
    {
        public F__PlatformSpecificImages()
        {
            InitializeComponent();
        }

        [Obsolete]
        public void ImageSpecific()
        {
            var images = new Image
            {
                Source = (FileImageSource)ImageSource.FromFile(Device.OnPlatform(
                iOS: "icon.png",
                Android: "icon.png",
                WinPhone: "Images/clock.png"))
            };
            Content = images;
        }
    }
}