using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.E_Navigation._Exercies.Domain;

namespace XamarinForms.E_Navigation._Exercies
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ActivityPage : ContentPage
    {
        private readonly ActivityService _activityService = new ActivityService();

        public ActivityPage()
        {
            InitializeComponent();

            GenerateActivityList();
        }

        public void GenerateActivityList()
        {
            ActivityListView.ItemsSource = _activityService.GetServices();
        }

        private async void ActivityListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            await  Navigation.PushAsync(new ActivityInfo((e.Item as Activity).UserId));
        }
    }
}