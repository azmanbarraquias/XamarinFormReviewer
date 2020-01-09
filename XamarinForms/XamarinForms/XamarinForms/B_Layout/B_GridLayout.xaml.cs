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
    public partial class B_GridLayout : ContentPage
    {
        public B_GridLayout()
        {
            InitializeComponent();
        }

        public void GridLayoutCodeBehind_1()
        {
            var grid = new Grid();

            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });

            var topLeft = new Label { Text = "Top Left", BackgroundColor = Color.Red };
            var topRight = new Label { Text = "Top Right", BackgroundColor = Color.Blue };
            var bottomLeft = new Label { Text = "Bottom Left", BackgroundColor = Color.Green };
            var bottomRight = new Label { Text = "Bottom Right", BackgroundColor = Color.Bisque };

            grid.Children.Add(topLeft, 0, 0);
            grid.Children.Add(topRight, 1, 0);
            grid.Children.Add(bottomLeft, 0, 1);
            grid.Children.Add(bottomRight, 1, 1);

            Content = grid;
        }

        public void GridLayoutCodeBehind_2()
        {
            Grid grid = new Grid
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                RowDefinitions =
                {
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = GridLength.Auto },
                    new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                    new RowDefinition { Height = new GridLength(100, GridUnitType.Absolute) }
                },
                ColumnDefinitions =
                {
                    new ColumnDefinition { Width = GridLength.Auto },
                    new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                    new ColumnDefinition { Width = new GridLength(100, GridUnitType.Absolute) }
                }
            };

            grid.Children.Add(new Label
            {
                Text = "Grid",
                BackgroundColor = Color.Red,
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            }, 0, 3, 0, 1); ;

            grid.Children.Add(new Label
            {
                Text = "Autosized cell",
                TextColor = Color.White,
                BackgroundColor = Color.Blue
            }, 0, 1);

            grid.Children.Add(new BoxView
            {
                Color = Color.Silver,
                HeightRequest = 0
            }, 1, 1);

            grid.Children.Add(new BoxView
            {
                Color = Color.Teal
            }, 0, 2);

            grid.Children.Add(new Label
            {
                Text = "Leftover space",
                TextColor = Color.Purple,
                BackgroundColor = Color.Aqua,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
            }, 1, 2);

            grid.Children.Add(new Label
            {
                Text = "Span two rows (or more if you want)",
                TextColor = Color.Yellow,
                BackgroundColor = Color.Navy,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 2, 3, 1, 3);

            grid.Children.Add(new Label
            {
                Text = "Span 2 columns",
                TextColor = Color.Blue,
                BackgroundColor = Color.Yellow,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 0, 2, 3, 4);

            grid.Children.Add(new Label
            {
                Text = "Fixed 100x100",
                TextColor = Color.Aqua,
                BackgroundColor = Color.Red,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center
            }, 2, 3);

            // Build the page.
            this.Content = grid;
        }

        public void GridLayoutCodeBehind_3()
        {
            var grid = new Grid
            {
                RowSpacing = 20,
                ColumnSpacing = 40
            };

            var label = new Label { Text = "Label 1", BackgroundColor = Color.HotPink };
            grid.Children.Add(label, 0, 0);

            // Late setting
            Grid.SetRowSpan(label, 2);
            Grid.SetColumnSpan(label, 2);

            Grid.SetRow(label, 0);
            Grid.SetColumn(label, 0);

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(2, GridUnitType.Star)
            });

            grid.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(1, GridUnitType.Auto)
            });

            Content = grid;
        }
    }
}