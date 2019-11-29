using System;
using System.Windows.Input;
using Xamarin.Forms;
using XFEssentialsTest.Views;

namespace XFEssentialsTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public ICommand ShareCommand { get; private set; }

        public MainViewModel()
        {
            ShareCommand = new Command(ShareExecute);
        }

        private void ShareExecute()
        {
            Application.Current.MainPage.Navigation.PushAsync(new SharePage());
        }
    }
}
