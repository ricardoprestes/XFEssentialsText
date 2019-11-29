using Xamarin.Forms;
using XFEssentialsTest.ViewModels;

namespace XFEssentialsTest.Views
{
    public partial class SharePage : ContentPage
    {
        public SharePage()
        {
            InitializeComponent();
            BindingContext = new ShareViewModel();
        }
    }
}
