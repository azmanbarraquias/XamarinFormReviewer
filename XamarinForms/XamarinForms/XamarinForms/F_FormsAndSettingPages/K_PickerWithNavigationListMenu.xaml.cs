using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.F_FormsAndSettingPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class K_PickerWithNavigationListMenu : ContentPage
    {
        public K_PickerWithNavigationListMenu()
        {
            InitializeComponent();
            GenerateList();
        }

        public void GenerateList()
        {
            MyListView.ItemsSource = new List<string>()
            {
                "Email",
                "SMS",
                "Call"
            };
        }

        // MyListView is private to expose it we code
       public ListView GetListInfo { get { return MyListView; } }
    }
}