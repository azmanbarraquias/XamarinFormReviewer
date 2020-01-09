using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.B_Layout._Exercises
{
  
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StackLayout_2 : ContentPage
    {
        private int _totalLikes = 700;
        public StackLayout_2()
        {
            InitializeComponent();
        }

        private void LikeButton(object sender, EventArgs e)
        {
            _totalLikes++;
            LikeLabel.Text = string.Format("{0} likes", _totalLikes);
        }
    }
}