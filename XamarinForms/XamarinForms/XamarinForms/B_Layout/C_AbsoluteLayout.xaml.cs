using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.B_Layout
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class C_AbsoluteLayout : ContentPage
    {
        public C_AbsoluteLayout()
        {
            InitializeComponent();

            //AbsoluteLayoutCodeBehind();
        }

        public void AbsoluteLayoutCodeBehind()
        {
            var abosoluteLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.FromHex("#35ED25"),
                Padding = 5,

                Children = { 
                    { 
                        new BoxView { 
                        BackgroundColor = Color.Red }, 
                        new Rectangle(0, 0.5, 1, 50), 
                        AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional } 
                    }
            };

            var aquaBox = new BoxView { Color = Color.Aqua };

            abosoluteLayout.Children.Add(aquaBox,
                                        new Rectangle(0, 0, 1, 1),
                                        AbsoluteLayoutFlags.All);

            // Late assign to change latter
            AbsoluteLayout.SetLayoutBounds(aquaBox, new Rectangle(0.5, 0.5, 0.85, 0.85));
            AbsoluteLayout.SetLayoutFlags(aquaBox, AbsoluteLayoutFlags.All);

            var aquaBox1 = new BoxView { Color = Color.Red };

            abosoluteLayout.Children.Add(aquaBox1, new Rectangle(0.5, 0.1, 100, 100), AbsoluteLayoutFlags.PositionProportional);

            abosoluteLayout.Children.Add(new Button { Text = "Do nothing button" },
                new Rectangle(0.5, 1, 1, 100), AbsoluteLayoutFlags.PositionProportional | AbsoluteLayoutFlags.WidthProportional);

            Content = abosoluteLayout;
        }
    }
}