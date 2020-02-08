using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinForms.G_DataAccess.Models;

namespace XamarinForms.G_DataAccess
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class K_LoadResourceXml : ContentPage
	{
		public K_LoadResourceXml()
		{
			InitializeComponent();
			LoadResourceXml();
		}
		public void LoadResourceXml()
		{
			#region How to load an XML file embedded resource
			var assembly = IntrospectionExtensions.GetTypeInfo(typeof(K_LoadResourceXml)).Assembly;
			Stream stream = assembly.GetManifestResourceStream("XamarinForms.G_DataAccess.ResourceFile.LibXmlResource.xml");

			List<Monkey> monkeys;
			using (var reader = new StreamReader(stream))
			{
				var serializer = new XmlSerializer(typeof(List<Monkey>));
				monkeys = (List<Monkey>)serializer.Deserialize(reader);
			}
			#endregion
			
			monkeylistview.ItemsSource = monkeys;
		}
	}
}