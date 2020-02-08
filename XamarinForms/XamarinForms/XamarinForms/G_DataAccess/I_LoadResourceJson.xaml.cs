using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Reflection;
using System.IO;
using Newtonsoft.Json;
using XamarinForms.G_DataAccess.Models;

namespace XamarinForms.G_DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class I_LoadResourceJson : ContentPage
    {
        public I_LoadResourceJson()
        {
            InitializeComponent();
            LoadJsonFile();
        }

        public void LoadJsonFile()
        {
            #region How to load an Json file embedded resource
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(I_LoadResourceJson)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("XamarinForms.G_DataAccess.ResourceFile.LibJsonResource.json");

            Earthquake[] earthquakes;
            using (var reader = new StreamReader(stream))
            {
                var json = reader.ReadToEnd();
                var rootobject = JsonConvert.DeserializeObject<Rootobject>(json);
                earthquakes = rootobject.Earthquakes;
            }
            ListViewItems.ItemsSource = earthquakes;
            #endregion
        }
    }
}