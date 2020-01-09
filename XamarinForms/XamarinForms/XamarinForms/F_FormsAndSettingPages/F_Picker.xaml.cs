using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.F_FormsAndSettingPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class F_Picker : ContentPage
	{
		/* Note: For performance reason it better to store the
		 result of a GetContactMethod in a private field */
		private readonly List<ContacatMethod> _contactMethod;
		public F_Picker()
		{
			InitializeComponent();

			_contactMethod = GetContactMethod();

			foreach (var person in GetContactMethod())
			{
				PickerX.Items.Add(person.Name);
			}
		}

		private void Picker_SelectedIndexChanged_Blue(object sender, EventArgs e)
		{
			// Events args do not carry the current selected item to get that we must give this picker a name

			var itemPicked = PickerMenu.Items[PickerMenu.SelectedIndex];
			DisplayAlert(PickerMenu.Title, itemPicked, "Ok");
		}

		// Code Behind
		private List<ContacatMethod> GetContactMethod()
		{
			return new List<ContacatMethod>
			{
				new ContacatMethod { Id = 0, Name="Azman"},
				new ContacatMethod { Id = 1, Name="Jazz"}
			};
		}

		private async void Picker_SelectedIndexChanged_Red(object sender, EventArgs e)
		{
			var itemPicked1 = PickerX.Items[PickerX.SelectedIndex];
			await DisplayAlert(PickerX.Title, itemPicked1, "Ok");

			var indexSelected = PickerX.SelectedIndex.ToString();

			await DisplayAlert(PickerX.Title, indexSelected, "Ok");

			var contactMethodObject = GetContactMethod().Select(cm => cm.Name == itemPicked1);

			await DisplayAlert(PickerX.Title, contactMethodObject.ToString(), "Ok");
		}
	}

	public class ContacatMethod
	{
		public int Id { get; set; }
		public string Name { get; set; }
	}	
}