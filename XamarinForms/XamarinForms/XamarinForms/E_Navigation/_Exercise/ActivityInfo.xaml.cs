using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.E_Navigation._Exercies.Domain;

namespace XamarinForms.E_Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityInfo : ContentPage
    {
        private readonly UserService _userService = new UserService();

        public ActivityInfo(int id)
        {
            if (id.Equals(null))
                throw new ArgumentNullException();

            InitializeComponent();

            GenerateUserInfo(id);
        }

        public void GenerateUserInfo(int id)    
        {
            var user = _userService.GetUser(id);
            this.BindingContext = user;
        }
    }
}