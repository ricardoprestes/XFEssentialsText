using System.Windows.Input;
using Xamarin.Forms;
using XFEssentialsTest.Views;

namespace XFEssentialsTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand ShareCommand { get; private set; }
        public ICommand SpeechCommand { get; private set; }
        public ICommand VersionTrackingCommand { get; private set; }
        public ICommand SettingsCommand { get; private set; }

        public MainViewModel()
        {
            ShareCommand = new Command(ShareExecute);
            SpeechCommand = new Command(SpeechExecute);
            VersionTrackingCommand = new Command(VersionTrackingExecute);
            SettingsCommand = new Command(SettingsExecute);
        }

        private void ShareExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SharePage());
        }

        private void SpeechExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new TextToSpeechPage());
        }

        private void VersionTrackingExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new VersionTrackingPage());
        }

        private void SettingsExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SettingsPage());
        }
    }
}
