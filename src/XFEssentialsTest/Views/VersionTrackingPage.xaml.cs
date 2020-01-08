using Xamarin.Forms;
using XFEssentialsTest.ViewModels;

namespace XFEssentialsTest.Views
{
    public partial class VersionTrackingPage : ContentPage
    {
        public VersionTrackingPage()
        {
            InitializeComponent();
            BindingContext = new VersionTrackingViewModel();
        }
    }
}
