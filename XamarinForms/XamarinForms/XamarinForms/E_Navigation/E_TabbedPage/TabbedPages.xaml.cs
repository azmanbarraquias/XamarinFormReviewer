using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinForms.A_XAMLEssentials.A;
using XamarinForms.A_XAMLEssentials.B;
using XamarinForms.A_XAMLEssentials.C;
using XamarinForms.A_XAMLEssentials.D;
using XamarinForms.A_XAMLEssentials.E;
using XamarinForms.A_XAMLEssentials.F;
using XamarinForms.A_XAMLEssentials._Exercise;

using XamarinForms.B_Layout;
using XamarinForms.B_Layout._Exercises;

using XamarinForms.C_Images;
using XamarinForms.C_Images._Exercises;

using XamarinForms.D_Lists;
using XamarinForms.D_Lists._Excercies;

//using XamarinForms.E_Navigation.
using XamarinForms.E_Navigation.A_HierarchicalNavigation;
using XamarinForms.E_Navigation.B_ModalPages;
using XamarinForms.E_Navigation.C_PassingData;

using XamarinForms.G_DataAccess;
using XamarinForms.E_Navigation.D_MasterDetailPage;
using XamarinForms.E_Navigation.D_MasterDetailPage.Sample;

namespace XamarinForms.E_Navigation.E_TabbedPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TabbedPages : TabbedPage
    {
        public TabbedPages()
        {
            InitializeComponent();

           // AddNewTabPage();

        }

        public void AddNewTabPageByCode()
        {
            this.Children.Add(new AbsoluteLayout_1());
            this.Children.Add(new NavigationPage(new FriendMaster()));
            this.Children.Add(new ContentPage());
        }
    }
}