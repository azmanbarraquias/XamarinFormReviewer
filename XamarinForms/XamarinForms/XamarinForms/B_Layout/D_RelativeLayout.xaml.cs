using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.B_Layout
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class D_RelativeLayout : ContentPage
	{
		public D_RelativeLayout()
		{
			InitializeComponent();
			RelativeLayout();
		}

		public void RelativeLayout()
		{
			var relativeLayout = new RelativeLayout();

			var boxView1 = new BoxView { Color = Color.Aqua };

			relativeLayout.Children.Add(boxView1,
			widthConstraint: Constraint.RelativeToParent(parent => parent.Width),
			heightConstraint: Constraint.RelativeToParent(parent => parent.Height * 0.3));

			var boxView2 = new BoxView { Color = Color.Blue };

			relativeLayout.Children.Add(boxView2,
			yConstraint: Constraint.RelativeToView(boxView1, (RelativeLayout, element) => element.Height + 20));

			Content = relativeLayout;
		}
	}
}