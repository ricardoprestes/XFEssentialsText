using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFEssentialsTest.ViewModels
{
    public class ShareViewModel : BaseViewModel
    {
        string _text;
        public string Text
        {
            get => _text;
            set => SetProperty(ref _text, value);
        }

        string _link;
        public string Link
        {
            get => _link;
            set => SetProperty(ref _link, value);
        }

        public ICommand ShareTextCommand { get; private set; }
        public ICommand ShareLinkCommand { get; private set; }

        public ShareViewModel()
        {
            ShareTextCommand = new Command(async () => await ShareTextExecute());
            ShareLinkCommand = new Command(async () => await ShareLinkExecute());
        }

        private async Task ShareTextExecute()
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Text = Text,
                Title = "Share Text"
            });
        }

        private async Task ShareLinkExecute()
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = Link,
                Title = "Share Link"
            });
        }
    }
}
