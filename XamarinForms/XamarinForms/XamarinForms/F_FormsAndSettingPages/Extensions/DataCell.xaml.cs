using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinForms.F_FormsAndSettingPages.Extensions
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DataCell : ViewCell
    {
        #region This is BindableProperty Architecture

        // Requirement to bind this class porperty to xaml. This is Bindable Infrastracture.
        // naming combination uiNameProperty
        // Create( NameOfProperty, Type of return, what is the type of declaring this BindableProperty)
        private static readonly BindableProperty _LabelProperty = BindableProperty.Create("Label", typeof(string), typeof(DataCell));

        public string Label
        {
            // GetValue and set value method from view cell
            get { return (string)GetValue(_LabelProperty); }
            set { SetValue(_LabelProperty, value); }
        }

        #endregion This is BindableProperty Architecture

        public DataCell()
        {
            InitializeComponent();

            BindingContext = this;
        }
    }
}