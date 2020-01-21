using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamarinForms.A_XAMLEssentials._Exercise;
using XamarinForms.A_XAMLEssentials;


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
using XamarinForms.E_Navigation.D_MasterDetailPage;
using XamarinForms.E_Navigation.D_MasterDetailPage.Sample;
using XamarinForms.E_Navigation.E_TabbedPage;
using XamarinForms.E_Navigation.F_CarouselPage;
using XamarinForms.E_Navigation.G_DisplayPopups;
using XamarinForms.E_Navigation.H_ToolbarItem;
using XamarinForms.E_Navigation._Exercies;

using XamarinForms.F_FormsAndSettingPages;
using XamarinForms.F_FormsAndSettingPages.ContactBook.View;
using XamarinForms.F_FormsAndSettingPages.ContactBookByMosh;


using XamarinForms.G_DataAccess;

namespace XamarinForms
{
    public partial class App : Application
    {
        // C_CleanerImplementation
        private const string TitleKey = "Name";
        private const string NotificationsKey = "NotificationsEnabled";

        public App()
        {
            InitializeComponent();

            // new NavigationPage ( new yourPage() ); - is to implement Navigation fuction

            // Starting point of page
            MainPage = new NavigationPage(new F_DeviceDifferences());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        #region C_CleanerImplementation
        public string Title
        {
            get
            {
                if (Properties.ContainsKey(TitleKey))
                {
                    return Properties[TitleKey].ToString();
                }
                else
                {
                    return "";
                }

            }
            set
            {
                Properties[TitleKey] = value;
                Current.SavePropertiesAsync();
            }
        }
        public bool NotificationsEnabled
        {
            get
            {
                if (Properties.ContainsKey(NotificationsKey))
                {
                    return (bool)Properties[NotificationsKey];
                }
                else
                {
                    return false;
                }

            }
            set 
            {
                Properties[NotificationsKey] = value;
                Current.SavePropertiesAsync();
            }
        }
        #endregion C_CleanerImplementation
    }
}