using Xamarin.Forms;
using XFEssentialsTest.ViewModels;

namespace XFEssentialsTest.Views
{
    public partial class TextToSpeechPage : ContentPage
    {
        public TextToSpeechPage()
        {
            InitializeComponent();

            BindingContext = new TextToSpeechViewModel();
        }
    }
}
