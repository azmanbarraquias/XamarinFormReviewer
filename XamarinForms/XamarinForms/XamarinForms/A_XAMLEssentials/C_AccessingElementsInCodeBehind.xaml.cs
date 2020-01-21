using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.A_XAMLEssentials
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_AccessingElementsInCodeBehind : ContentPage
    {
        public C_AccessingElementsInCodeBehind()
        {
            InitializeComponent();

            slider.Value = 0.50d;
            // if the value is 0 the text will not be change
        }

        private void SlideValueChanged(object sender, ValueChangedEventArgs e)
        {
            // We access all of the property on Label name SliderHeaderText
            SliderHeaderText.Text = String.Format("Slider Value: {0:F2}", e.NewValue);
        }
    }
}