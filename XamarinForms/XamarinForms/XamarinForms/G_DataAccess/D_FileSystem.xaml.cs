using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System.IO;

namespace XamarinForms.G_DataAccess
{
	/// <summary>
	/// This page includes input boxes and buttons that allow the text to be
	/// saved-to and loaded-from a file.
	/// </summary>
	/// 
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class D_FileSystem : ContentPage
	{
		string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "testFile.txt");

		public D_FileSystem()
		{
			InitializeComponent();
			PathFileDisplay.Text = fileName;
		}

		private void SaveButton(object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace(InputField.Text))
			{
			 File.WriteAllText(fileName, InputField.Text);
			DisplayAlert("Saved", "", "Ok");

			}
			else
			{
				DisplayAlert("", "Text field required a content in order to save", "Ok");
			}

		}

		private void LoadButton(object sender, EventArgs e)
		{
			if (File.Exists(fileName))
			{
				LoadTxtDisplay.Text = File.ReadAllText(fileName) + "\nEND";
				DisplayAlert("File Loaded", "", "Ok");
			}
			else
			{
				DisplayAlert("Cannot find files", "", "Ok");
			}
		}
	}
}