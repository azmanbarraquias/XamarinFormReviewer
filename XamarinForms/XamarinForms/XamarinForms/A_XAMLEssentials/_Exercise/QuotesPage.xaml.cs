using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.A_XAMLEssentials._Exercise
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        readonly string[] quotes =
            { "I love you the more in that I believe you had liked me for my own sake and for nothing else.",
              "But man is not made for defeat. A man can be destroyed but not defeated.",
              "When you reach the end of your rope, tie a knot in it and hang on.",
              "There is nothing permanent except change.",
              "You cannot shake hands with a clenched fist.",
              "Let us sacrifice our today so that our children can have a better tomorrow." };
        private int _index = 0;

        public QuotesPage()
        {
            InitializeComponent();
            DesplayNextQuotes();
        }

        private void NextQuotesButton(object sender, EventArgs e)
        {
            DesplayNextQuotes();
        }


        private void DesplayNextQuotes()
        {
            if (_index >= quotes.Length)
                _index = 0;

            QuotesText.Text = quotes[_index];
            _index++;
        }
    }
}