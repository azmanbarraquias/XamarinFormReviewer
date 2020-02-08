using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.G_DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class J_LoadResourceText : ContentPage
    {
        public J_LoadResourceText()
        {
            InitializeComponent();
            LoadResourceText();

        }

        public void LoadResourceText()
        {
            #region How to load a text file embedded resource
            var assembly = IntrospectionExtensions.GetTypeInfo(typeof(J_LoadResourceText)).Assembly;
            Stream stream = assembly.GetManifestResourceStream("XamarinForms.G_DataAccess.ResourceFile.LibTextResource.txt");

            string text = "";
            using (var reader = new StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }
            #endregion

            editor.Text = text;
        }
    }
}