using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.B_Layout._Exercises
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GridLayout_1 : ContentPage
    {
        public GridLayout_1()
        {
            InitializeComponent();
        }

        private void DisplayNumber(string dialNumber)
        {
            DialInputDisplay.Text += dialNumber;
        }

        private void DialButton1(object sender, EventArgs e)
        {
            DisplayNumber("1");
        }

        private void DialButton2(object sender, EventArgs e)
        {
            DisplayNumber("2");
        }

        private void DialButton3(object sender, EventArgs e)
        {
            DisplayNumber("3");
        }

        private void DialButton4(object sender, EventArgs e)
        {
            DisplayNumber("4");
        }

        private void DialButton5(object sender, EventArgs e)
        {
            DisplayNumber("5");
        }

        private void DialButton6(object sender, EventArgs e)
        {
            DisplayNumber("6");
        }

        private void DialButton7(object sender, EventArgs e)
        {
            DisplayNumber("7");
        }

        private void DialButton8(object sender, EventArgs e)
        {
            DisplayNumber("8");
        }

        private void DialButton9(object sender, EventArgs e)
        {
            DisplayNumber("9");
        }

        private void DialButton0(object sender, EventArgs e)
        {
            DisplayNumber("0");
        }

        private void DialButtonAsterisk(object sender, EventArgs e)
        {
            DisplayNumber("*");
        }

        private void DialButtonHash(object sender, EventArgs e)
        {
            DisplayNumber("#");
        }

        private void SaveDialNumber(object sender, EventArgs e)
        {
            DisplayAlert("Sorry", "The save dial number is still uundergoing maintenance..", "Close");
        }

        private void DialButton(object sender, EventArgs e)
        {
            var numberToDial = DialInputDisplay.Text;
            if (!string.IsNullOrEmpty(numberToDial))
            {
                PhoneDialer.Open(DialInputDisplay.Text);
            }
            else
            {
                DisplayAlert("Warning", "There's no number", "Close");
            }
        }

        private void ClearDialDisplay(object sender, EventArgs e)
        {
            List<char> letters = new List<char>(DialInputDisplay.Text);
            DialInputDisplay.Text = "";
            for (int i = 0; i < letters.Count - 1; i++)
            {
                DialInputDisplay.Text += letters[i];
            }
            letters.Clear();
        }
    }
}