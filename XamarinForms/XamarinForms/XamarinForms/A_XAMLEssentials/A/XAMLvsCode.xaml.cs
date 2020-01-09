using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.A_XAMLEssentials.A
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class XAMLvsCode : ContentPage
    {
        public XAMLvsCode()
        {
            InitializeComponent(); // XAML called 1st
                                   // XAML will be extrated to assemply the passed to xaml parser and generate UI like codebehind

            CreateUIByCodeBehind(); // then Codebehind 2nd
        }

        public void CreateUIByCodeBehind()
        {
            /* XAML UI
            <  Label
               FontAttributes = "Bold"
               FontSize = "30"
               HorizontalOptions = "Center"
               HorizontalTextAlignment = "Center"
               Text = "XAML"
               TextColor = "#000073"
               VerticalOptions = "Center" />
           */

            // Code UI
            // Content derive from ContentPage base Class
            Content = new Label
            {
                FontAttributes = FontAttributes.Bold,
                FontSize = 30,
                HorizontalOptions = LayoutOptions.Center,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Code Behind!",
                TextColor = Color.FromHex("#000073"),
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}