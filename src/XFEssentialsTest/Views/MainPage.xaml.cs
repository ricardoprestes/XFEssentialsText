using System.ComponentModel;
using Xamarin.Forms;
using XFEssentialsTest.ViewModels;

namespace XFEssentialsTest.Views
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
