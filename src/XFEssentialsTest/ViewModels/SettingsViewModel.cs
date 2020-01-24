using System;
using System.Windows.Input;
using Xamarin.Forms;
using XFEssentialsTest.Helpers;

namespace XFEssentialsTest.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        string _token;
        public string Token
        {
            get => _token;
            set => SetProperty(ref _token, value);
        }

        public ICommand SaveCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }

        public SettingsViewModel()
        {
            Token = Settings.Token;

            SaveCommand = new Command(SaveExecute);
            ResetCommand = new Command(ResetExecute);
        }

        private void SaveExecute()
        {
            Settings.Token = Token;
        }

        private void ResetExecute()
        {
            Settings.Reset();
            Token = null;
        }
    }
}
