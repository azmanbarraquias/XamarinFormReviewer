using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.A_XAMLEssentials.F
{
    [XamlCompilation(XamlCompilationOptions.Compile)] // you can change to .Skip
    public partial class DeviceDifferences : ContentPage
    {
        public DeviceDifferences()
        {
            InitializeComponent();
            //DeviceDifferencesChecker();
        }

        public void DeviceDifferencesChecker()
        {
            if (Device.RuntimePlatform == Device.iOS)
            {
                //Do Something
                Padding = new Thickness(10, 0, 0, 0);
            }
            if (Device.RuntimePlatform == Device.Android)
            {
                //Do Something
                Padding = new Thickness(20, 0, 0, 0);
            }
            if (Device.RuntimePlatform == Device.UWP)
            {
                //Do Something
                Padding = new Thickness(30, 0, 0, 0);
            }
        }

        [Obsolete]
        public void DeviceDifferencesChecker1()
        {
            Padding = Device.OnPlatform<Thickness>
                (
                    iOS: new Thickness(10, 0, 0, 0),
                    Android: new Thickness(20, 0, 0, 0),
                    WinPhone: new Thickness(30, 0, 0, 0)
                );
        }

        [Obsolete]
        public void DeviceDifferencesChecker2()
        {
            Device.OnPlatform(
                iOS: () =>
                {
                    Padding = new Thickness(10, 0, 0, 0);
                },
                Android: () =>
                {
                    Padding = new Thickness(10, 0, 0, 0);
                },
                WinPhone: () =>
                {
                    Padding = new Thickness(10, 0, 0, 0);
                } );
        }
    }
}