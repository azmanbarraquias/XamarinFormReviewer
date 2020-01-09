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
    public partial class A_StackLayout : ContentPage
    {
        public A_StackLayout()
        {
            InitializeComponent(); //XAML

            // StackLayoutCodeBehind(); // Code-behind
        }

        [Obsolete("BorderRadius is Obsolete")]
        public void StackLayoutCodeBehind()
        {
            var stackLayout = new StackLayout
            {
                Spacing = 20,
                Padding = new Thickness(20),
                BackgroundColor = Color.Yellow,
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,

                Children = { new Button { Text = "XAML",
                                          BackgroundColor = Color.Pink,
                                          TextColor = Color.Black,
                                          BorderRadius = 20, //Obsolete
                                          BorderColor = Color.Black,
                                          BorderWidth = 5,
                                          Command = new Command( execute: () => InitializeComponent() ),
                                          FontAttributes = FontAttributes.Bold,
                                          VerticalOptions = LayoutOptions.Center },
                            new StackLayout { Padding = new Thickness(5),
                                              BackgroundColor=Color.LightCoral,
                                              Children = {  new Image { Source = "http://placehold.it/100x100" },
                                                            new Label { Padding = new Thickness(5, 2, 5, 2),
                                                                        Text = "Label 1",
                                                                        HorizontalTextAlignment = TextAlignment.Center,
                                                                        TextColor = Color.White,
                                                                        BackgroundColor = Color.Black }
                                                            }
                                              },
                            new StackLayout { Padding = new Thickness(5),
                                                              BackgroundColor=Color.LightCoral,
                                                              Children = { new Label { Padding = new Thickness(5, 2, 5, 2),
                                                                              Text = "Label 1",
                                                                              HorizontalTextAlignment = TextAlignment.Center,
                                                                              TextColor = Color.White,
                                                                              Rotation = 180,
                                                                              BackgroundColor = Color.Black },
                                                                        new Image { Source = "http://placehold.it/100x100" }
                                                              }
                                             }
                            }
            };

            // Add UI to its child

            var stackLayout1 = new StackLayout
            {
                Padding = new Thickness(5),
                BackgroundColor = Color.CornflowerBlue
            };

            stackLayout1.Children.Add( new Image { Rotation = 45, Source = "http://placehold.it/100x100" } );
            stackLayout1.Children.Add( new Label{ Padding = new Thickness(5, 2, 5, 2),
                                                  BackgroundColor = Color.Black,
                                                  Text = "Label 1",
                                                  TextColor = Color.White,
                                                  HorizontalTextAlignment = TextAlignment.Center });

            stackLayout.Children.Add(stackLayout1);

            Content = stackLayout;
        }

        [Obsolete("BorderRadius is Obsolete")]
        private void CodeBehindButton(object sender, EventArgs e)
        {
            StackLayoutCodeBehind();
        }
    }
}