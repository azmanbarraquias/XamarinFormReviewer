using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.C_Images;

namespace XamarinForms.C_Images.MarkupExtensions
{
    [ContentProperty("ResourceID")]
    // ContentProperty("ResourceID")
    // Before: Source="{local:EmbeddedImageInXAML ResourceID=Azman.jpg}" />
    // After: Source="{local:EmbeddedImageInXAML Azman.jpg}" />
    class EmbeddedImageInXAML : IMarkupExtension
    {
        public string ResourceID { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (string.IsNullOrWhiteSpace(ResourceID))
            {
                return null;
            }
            
            return ImageSource.FromResource("XamarinForms.C_Images.ImagesFolder." + ResourceID);
        }
    }
}
