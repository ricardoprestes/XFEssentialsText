using Xamarin.Forms;
using XFEssentialsTest.ViewModels;

namespace XFEssentialsTest.Views
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();
            BindingContext = new SettingsViewModel();
        }
    }
}
