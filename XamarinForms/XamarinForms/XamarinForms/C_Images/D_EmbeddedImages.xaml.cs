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
    public partial class D_EmbeddedImages : ContentPage
    {
        public D_EmbeddedImages()
        {
            InitializeComponent();
            LoadImageFromFolder();
        }

        public void LoadImageFromFolder()
        {
            Image1.Source = ImageSource.FromResource("XamarinForms.C_Images.ImagesFolder.background.jpg");
        }
    }
}